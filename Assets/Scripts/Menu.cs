﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public GameObject mainMenuHolder;
	public GameObject optionsMenuHolder;

	public Slider[] volumeSliders;
	public Toggle[] resolutionToggles;
	public int[] screenWidths;
	int activeScreenResIndex;

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
		if (resolutionToggles [i].isOn) {
			activeScreenResIndex = i;
			float aspectRatio = 16 / 9f;
			Screen.SetResolution (screenWidths [i], (int)(screenWidths[i]/aspectRatio), false);
		}
	}

	public void SetFullscreen(bool isFullScreen) {
		for (int i = 0; i < resolutionToggles.Length; i++) {
			resolutionToggles [i].interactable = !isFullScreen;
		}
		if (isFullScreen) {
			Resolution[] allResolutions = Screen.resolutions;
			Resolution maxResolution = allResolutions [allResolutions.Length - 1];
			Screen.SetResolution (maxResolution.width, maxResolution.height, true);
		} else {
			SetScreenResolution (activeScreenResIndex);
		}
	}

	public void SetMasterVolume(float value) {
		
	}

	public void SetMusicVolume(float value) {

	}

	public void SetSfxVolume(float value) {

	}
}
