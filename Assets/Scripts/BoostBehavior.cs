using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostBehavior : MonoBehaviour {

    Rigidbody self;
    bool launching;
    public AudioSource launchSource;

    private void OnTriggerEnter(Collider zone)
    {
        if (zone.tag == "Trigger")
        {
            launchSource.Play(0);
            launching = true;
        }
    }

    private void OnTriggerExit(Collider zone)
    {
        if (zone.tag == "Trigger")
        {
            launching = false;
        }
    }

    void Start()
    {
        self = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
	void Update ()
    {
        if (launching == true)
        {
            // launch player into the air on contact
            self.AddForce(transform.up * 100);
        }

    }
}
