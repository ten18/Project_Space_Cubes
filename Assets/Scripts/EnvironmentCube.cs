using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentCube : MonoBehaviour {

    //float rotSpeed = 5;
    Rigidbody rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        // set random rotation
        float rotSpeedX = Random.Range(-10,10);
        float rotSpeedY = Random.Range(-10, 10);
        float rotSpeedZ = Random.Range(-10, 10);
        rb.AddTorque(rotSpeedX, rotSpeedY, rotSpeedZ);
        
    }
}
