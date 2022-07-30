using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {

	public float ghostSpeed;
	private Rigidbody2D theRB;
	// Use this for initialization
	void Start () {
		theRB = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			FindObjectOfType<GameManagement> ().HurtP ();
			theRB.velocity = new Vector2 (-ghostSpeed * transform.localScale.x, 0);
		} else if (other.tag == "leftBorder") {
			theRB.velocity = new Vector2 (ghostSpeed * transform.localScale.x, 0);
		} else if (other.tag == "rightBorder") {
			theRB.velocity = new Vector2 (-ghostSpeed * transform.localScale.x, 0);
		} 

	}

}


