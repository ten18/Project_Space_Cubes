using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {
	
	public void ReloadScene()
	{
		int currentScene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentScene);
		Debug.Log("Reloading scene");
	}

	public void LoadScene(int sceneNumber)
	{
		SceneManager.LoadScene(sceneNumber);
	}
}
