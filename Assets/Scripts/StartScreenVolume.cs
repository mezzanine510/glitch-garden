using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenVolume : MonoBehaviour {

	private MusicManager musicManager;

	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();

		musicManager.SetVolume(PlayerPrefsManager.GetMasterVolume());
	}

}
