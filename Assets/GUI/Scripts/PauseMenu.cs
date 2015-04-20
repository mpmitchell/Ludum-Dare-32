using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	[SerializeField] GameObject pauseButton;
	[SerializeField] GameObject pauseMenu;

	public void Pause() {
		Time.timeScale = 0.0f;
		pauseButton.SetActive(false);
		pauseMenu.SetActive(true);
	}

	public void Play() {
		Time.timeScale = 1.0f;
		pauseButton.SetActive(true);
		pauseMenu.SetActive(false);
	}

	public void Restart() {
		Time.timeScale = 1.0f;
		Application.LoadLevel(Application.loadedLevel);
	}

	public void Exit() {
		Time.timeScale = 1.0f;
		Application.LoadLevel("Level Select");
	}
}
