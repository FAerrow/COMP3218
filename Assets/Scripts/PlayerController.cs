using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerCharacter))]
public class PlayerController : MonoBehaviour {

    private PlayerCharacter character;
    private bool jump;

	// Use this for initialization
	void Awake () {
        character = GetComponent<PlayerCharacter>();
	}
	
	void Update () {
		if (!jump) {
            jump = Input.GetButtonDown("Jump");
        }
	}

    private void FixedUpdate() {
        float h = Input.GetAxis("Horizontal");
        character.Move(h, jump);
        jump = false;
    }
}
