using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour {

	private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
		boxCollider = GetComponent <BoxCollider2D> ();
		rb2D = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E))
		{
			rb2D.velocity = new Vector3(0,10,0);
		}
	}
}
