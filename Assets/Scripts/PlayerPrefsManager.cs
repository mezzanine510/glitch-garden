﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume(float volume)
	{
		if (volume > 0f && volume < 1f)
		{
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		}
		else
		{
			Debug.LogError("Master volume out of range");
		}
	}

	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel(int level)
	{
		if (level <= SceneManager.sceneCountInBuildSettings - 1)
		{
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); // use 1 for true
		}
		else
		{
			Debug.LogError("Trying to unlock level that doesn't exist");
		}
	}

	public static bool IsLevelUnlocked(int level)
	{
		int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
		bool isLevelUnlocked = (levelValue == 1);

		if (level <= SceneManager.sceneCountInBuildSettings - 1)
		{
			return isLevelUnlocked;
		}
		else
		{
			Debug.LogError("Trying to query level that doesn't exist");
			return false;
		}
	}

	public static void SetDifficulty(float difficulty)
	{
		if (difficulty >= 1f && difficulty <= 3)
		{
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		}
		else
		{
			Debug.LogError("Difficulty out of range");
		}
	}

	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
}