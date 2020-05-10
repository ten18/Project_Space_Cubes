using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardCube : MonoBehaviour {

    Rigidbody rb;
    float startPosY;
    float startPosZ;

	void Start () {
        rb = GetComponent<Rigidbody>();
        startPosY = transform.position.y;
        startPosZ = transform.position.z;
        // set random spin
        float rotSpeedX = Random.Range(-20, 20);
        float rotSpeedY = Random.Range(-20, 20);
        float rotSpeedZ = Random.Range(-20, -15);
        rb.AddTorque(rotSpeedX, rotSpeedY, rotSpeedZ);
    }

	void Update () {
        // push object forward
        rb.velocity = new Vector3(10, 0, 0);
        // reset to original position once out of bounds
        if (transform.position.x >= 150)
        {
            transform.position = new Vector3(-50, startPosY, startPosZ);
        }
	}
}
