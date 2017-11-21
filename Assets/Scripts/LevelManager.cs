using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float secondsToLoadNextLevel;

	void Start()
	{
		if (secondsToLoadNextLevel > 0f)
		{
			Invoke("LoadNextLevel", secondsToLoadNextLevel);
		}
		else
		{
			Debug.Log("Level auto load disabled, use a positive number in seconds");
		}
	}

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		SceneManager.LoadScene (name);
	}

	public void QuitRequest()
	{
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
