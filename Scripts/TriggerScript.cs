using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	public SceneManagerScript reloadScript;
	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider other)
	{
		reloadScript.ReloadScene();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
