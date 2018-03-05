using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalReach : MonoBehaviour {

    public TagType tag;
    private string type;

    private void Start() {
        SetTag();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == type) {
            Destroy(this.gameObject);
        }
    }

    private void SetTag() {
        switch (tag) {
            case TagType.Player:
                type = "Player";
                break;
            case TagType.Fish:
                type = "Fish";
                break;
        }
    }

    public enum TagType {
        Player, Fish
    }
}
