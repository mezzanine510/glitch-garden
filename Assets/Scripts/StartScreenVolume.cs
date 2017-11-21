﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenVolume : MonoBehaviour {

	private MusicManager musicManager;

	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();

		if (musicManager)
		{
			float volume = PlayerPrefsManager.GetMasterVolume();
			musicManager.SetVolume(volume);
		}
		else
		{
			Debug.LogWarning("No music manager found in Start scene, can't set volume.");
		}
	}

}
