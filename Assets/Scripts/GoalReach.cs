using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalReach : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Fish") {
            Destroy(this.gameObject);
        }
    }
}
