using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetPlayer : MonoBehaviour {

    public GameObject resetNet;
    Rigidbody self;
    public static bool playerFell;
    Vector3 spawnPos;
    Quaternion spawnRot;
    public AudioSource fallSource;

    private void OnTriggerEnter(Collider net)
    {
        if (net.tag == "Boundary")
        {
            // when player falls:
            fallSource.Play(0);
            transform.position = spawnPos;
            transform.rotation = spawnRot;
            playerFell = true;
        }
        if (net.tag == "Checkpoint")
        {
            // respawn player at last checkpoint
            spawnPos = new Vector3(net.transform.position.x, net.transform.position.y + 1, net.transform.position.z);
        }
    }

    // Use this for initialization
    void Start () {
        self = GetComponent<Rigidbody>();
        spawnPos = transform.position;
        spawnRot = new Quaternion(0,0,0,0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
