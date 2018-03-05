using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalReach : MonoBehaviour {

    public int level;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            SceneManager.LoadScene("LVL" + level.ToString());
        }
    }
}
