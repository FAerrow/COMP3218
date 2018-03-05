using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBait : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Fish") {
            Destroy(this.gameObject);
            GameObject.Find("Game").GetComponent<GameController>().DecrementBaitCount();
        }
    }
}
