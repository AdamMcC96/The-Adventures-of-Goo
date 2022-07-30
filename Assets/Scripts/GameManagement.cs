using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {

	public GameObject player;
	public GameObject player2;
	public GameObject ghost;
	public GameObject ghost2;
	public double PLife;
	public double PLife2;
	public int GLife;
	public int GLife2;
	public GameObject gameOver;
	public GameObject P1win;

	public GameObject levelFinish;
	public GameObject[] pHP;
	public GameObject[] pHP2;
	public AudioSource hitSound;
	public AudioSource ghostDie;
	public string mainMenu;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (PLife <= 0) {
			player.SetActive (false);
			gameOver.SetActive (true);


		}if (PLife2 <= 0 && PLife > 0) {
			player2.SetActive (false);
			P1win.SetActive (true);

		}if (GLife <= 0) {
			ghost.SetActive (false);
			ghostDie.Play();

		}if (GLife2 <= 0) {
			ghost2.SetActive (false);
			ghostDie.Play();

		}if (GLife <= 0 && GLife2 <= 0) {
			levelFinish.SetActive (true);
		}
		if (Input.GetKeyDown(KeyCode.R)) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene(mainMenu);
		}
	}
	public void HurtTP() {
		PLife -= 1;
		for (int i = 0; i < pHP.Length; i++) {
			if (PLife > i) {
				pHP [i].SetActive (true);

			} else {
				pHP[i].SetActive(false);

			}
		
		}
		hitSound.Play();
	}
	public void HurtP() {
		PLife -= .5;
		for (int i = 0; i < pHP.Length; i++) {
			if (PLife > i) {
				pHP [i].SetActive (true);

			} else {
				pHP[i].SetActive(false);

			}

		}
		hitSound.Play();
	}
	public void HurtP2() {
		PLife2 -= 1;
		for (int i = 0; i < pHP2.Length; i++) {
			if (PLife2 > i) {
				pHP2[i].SetActive (true);

			} else {
				pHP2[i].SetActive(false);

			}

		}
		hitSound.Play();
	}



	public void HurtG() {
		GLife -= 1;
		hitSound.Play();
	}
	public void HurtG2() {
		GLife2 -= 1;
		hitSound.Play();
	}

}
