using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float timeToLoadNextLevel;

	void Start()
	{
		if (timeToLoadNextLevel == 0f)
		{
			Debug.Log("Level auto load disabled");
		}
		else
		{
			Invoke("LoadNextLevel", timeToLoadNextLevel);
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
