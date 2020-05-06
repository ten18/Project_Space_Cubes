using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

	// Use this for initialization
	public float projSpeed = 80;
	private Rigidbody rb;
	public GameObject target;
	public float selfDestructTime = 1;
	void Start () {
		rb = GetComponent<Rigidbody>();
		target = GameObject.Find("RigidBodyFPSController"); // home in on player
	}

	void OnTriggerEnter(Collider other)
	{
		StartCoroutine(SelfDestruct());
	}

	IEnumerator SelfDestruct() // destroy projectiles to avoid infinite spawns
	{
		yield return new WaitForSeconds(selfDestructTime);
		Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.LookAt(target.transform);
		rb.AddForce(transform.forward * projSpeed, ForceMode.Impulse); // use add force; transform doesn't impact player
	}
}
