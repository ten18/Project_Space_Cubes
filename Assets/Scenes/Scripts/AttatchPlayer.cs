using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttatchPlayer : MonoBehaviour {

	public GameObject Player;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find("RigidBodyFPSController");
	}
	// This only seems to work with the RigidBody version of the FPS controller

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == Player)
		{
			Player.transform.parent = transform;
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject == Player)
		{
			Player.transform.parent = null;
		}
	}

}
