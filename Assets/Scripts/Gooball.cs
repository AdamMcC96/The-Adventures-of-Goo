using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gooball : MonoBehaviour
{
	public float ballSpeed;
	private Rigidbody2D theRB;
	public GameObject gooballEffect;
	// Use this for initialization
	void Start ()
	{
		theRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		theRB.velocity = new Vector2 (ballSpeed * transform.localScale.x, 0);
	}
	void OnTriggerEnter2D(Collider2D did) {
		if (did.tag == "Ghost") {
			FindObjectOfType<GameManagement>().HurtG();
		}if (did.tag == "Ghost2") {
			FindObjectOfType<GameManagement>().HurtG2();
		}if (did.tag == "Player") {
			FindObjectOfType<GameManagement>().HurtTP();
		}if (did.tag == "Player1") {
			FindObjectOfType<GameManagement>().HurtP2();
		}
		Instantiate (gooballEffect, transform.position, transform.rotation);
		Destroy(gameObject);	
	}
}

