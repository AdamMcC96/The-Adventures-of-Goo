using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public string level1Scene;
	public string level2Scene;
	public string level3Scene;
	public string levelEXScene;
	public string TwoPlayerScene;

	public void Level1() {
		SceneManager.LoadScene (level1Scene);
	}public void Level2() {
		SceneManager.LoadScene (level2Scene);
	}public void Level3() {
		SceneManager.LoadScene (level3Scene);
	}public void LevelEX() {
		SceneManager.LoadScene (levelEXScene);
	}public void TwoPlayer() {
		SceneManager.LoadScene (TwoPlayerScene);
	}

	public void QuitGame() {
		Application.Quit();
	}

}

