using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject mainMenuHolder;
	public GameObject optionsMenuHolder;

	public void Play() {
		SceneManager.LoadScene ("Game");
	}

	public void Quit() {
		Application.Quit ();
	}

	public void OptionsMenu() {
		mainMenuHolder.SetActive (false);
		optionsMenuHolder.SetActive (true);
	}

	public void MainMenu() {
		optionsMenuHolder.SetActive (false);
		mainMenuHolder.SetActive (true);
	}

	public void SetScreenResolution(int i) {

	}

	public void SetFullscreen(bool isFullScreen) {

	}

	public void SetMasterVolume(float value) {
		
	}

	public void SetMusicVolume(float value) {

	}

	public void SetSfxVolume(float value) {

	}
}
