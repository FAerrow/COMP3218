using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    public float maxSpeed;
    public float jumpPower;
    public LayerMask groundLayer;

    private Rigidbody2D rBody2D;
    private Transform groundArea;
    [SerializeField] private bool grounded;
    private bool faceLeft = false;
    private Animator animator;

	// Use this for initialization
	void Awake() {
        rBody2D = GetComponent<Rigidbody2D>();
        groundArea = transform.Find("GroundArea");
        animator = GetComponent<Animator>();
	}

    void FixedUpdate() {
        grounded = false;

        Collider2D[] colliders = Physics2D.OverlapBoxAll(groundArea.position, new Vector2(0.28f, 0.1f), 0f, groundLayer);
        for (int i = 0; i < colliders.Length; i++) {
            if (colliders[i].gameObject != gameObject)
                grounded = true;
        }

        if (animator) {
            animator.SetBool("Grounded", grounded);
            animator.SetFloat("vSpeed", rBody2D.velocity.y);
        }
        
    }

    private void Flip() {
        faceLeft = !faceLeft;
        
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void Move(float moveHorizontal, bool jump) {

        if (animator) animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

        rBody2D.velocity = new Vector2(moveHorizontal * maxSpeed, rBody2D.velocity.y);

        if (moveHorizontal > 0 && faceLeft) {
            Flip();
        } else if (moveHorizontal < 0 && !faceLeft) {
            Flip();
        }

        if (grounded && jump) {
            grounded = false;
            if (animator.GetBool("Grounded")) animator.SetBool("Grounded", false);
            rBody2D.AddForce(new Vector2(0f, jumpPower));
        }
    }
}
