using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource; // Declare an AudioSource variable.

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	void Start()
	{
		audioSource = GetComponent<AudioSource>(); // Put the audio source into a variable you can use.
	}

	void OnLevelWasLoaded(int level)
	{
		AudioClip thisLevelMusic = levelMusicChangeArray[level];

		if (thisLevelMusic && audioSource.clip != thisLevelMusic) // If there's some music attached to the array:
		{
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}

	}

	public void SetVolume(float volume)
	{
		audioSource.volume = volume;
	}

}
