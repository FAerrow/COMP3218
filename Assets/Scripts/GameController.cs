using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject baitObject;
    public int baitAmount;
    private int baitCount;

    // Use this for initialization
    void Start () {
        SpawnBaits();
    }
	
	// Update is called once per frame
	void Update () {
        if (baitCount == 0) {
            SpawnBaits();
        }
    }

    private void SpawnBaits() {
        for (int i = 0; i < baitAmount; i++) {
            Vector3 position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-2.0f, 3.5f), 0);
            Instantiate(baitObject, position, Quaternion.identity);
        }
        baitCount = GameObject.FindGameObjectsWithTag("Bait").Length;
    }

    public void DecrementBaitCount() {
        baitCount -= 1;
    }
}
