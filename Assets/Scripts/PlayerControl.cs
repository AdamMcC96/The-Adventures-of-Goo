﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {


	public float moveSpeed;
	public float jumpForce;
	public KeyCode left;
	public KeyCode right;
	public KeyCode jump;
	public KeyCode shoot;
	public Transform groundCheckPoint;
	public bool isGrounded;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public GameObject gooBall;
	public Transform throwPoint;
	public AudioSource throwSound;

	private Rigidbody2D theRB;
	private Animator anim;
	// Use this for initialization
	void Start () {
		theRB = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		isGrounded = Physics2D.OverlapCircle (groundCheckPoint.position, groundCheckRadius, whatIsGround);
		if (Input.GetKey (left)) {
			theRB.velocity = new Vector2 (-moveSpeed, theRB.velocity.y);
		} else if (Input.GetKey (right)) {
			theRB.velocity = new Vector2 (moveSpeed, theRB.velocity.y);
		} else {
			theRB.velocity = new Vector2 (0, theRB.velocity.y);
		}

		if (Input.GetKeyDown (jump) && isGrounded) {
			theRB.velocity = new Vector2 (theRB.velocity.x, jumpForce);
		} 
		if (Input.GetKeyDown (shoot)) {
			GameObject ballClone =(GameObject) Instantiate (gooBall, throwPoint.position, throwPoint.rotation);
			ballClone.transform.localScale = transform.localScale;

			anim.SetTrigger("Throw");
			throwSound.Play();
		}
		if (theRB.velocity.x < 0) {
			transform.localScale = new Vector3 (-1, 1, 1);

		} else if (theRB.velocity.x > 0) {
			transform.localScale = new Vector3 (1, 1, 1);

		}
		anim.SetFloat ("Speed", Mathf.Abs(theRB.velocity.x));
		anim.SetBool ("Grounded", isGrounded);

	}

}
