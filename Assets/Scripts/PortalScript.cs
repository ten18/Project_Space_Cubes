using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour {

	public SceneManagerScript sceneLoadingScript;
	public int destinationLevel;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{ sceneLoadingScript.LoadScene(destinationLevel); }
	}

}
