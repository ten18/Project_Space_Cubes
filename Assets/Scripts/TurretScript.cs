using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {


	private GameObject target;
	public GameObject bullet;
	public GameObject snout;
	private bool targetLocked;
    public AudioSource turretSource;

	public float fireTime;
	private bool shotReady;
	// Use this for initialization
	void Start () {
		shotReady = true;
		targetLocked = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (targetLocked)
		{
			gameObject.transform.LookAt(target.transform);
			if (shotReady)
			{
				Shoot();
                turretSource.Play(0);
			}
		}
	}

	void Shoot()
	{
		Transform _bullet = Instantiate(bullet.transform, snout.transform.position, Quaternion.identity);
		_bullet.transform.rotation = gameObject.transform.rotation;
		shotReady = false;
		StartCoroutine(FireRate());
	}

	IEnumerator FireRate()
	{
		yield return new WaitForSeconds(fireTime);
		shotReady = true;
	}
	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{
			target = other.gameObject;
			targetLocked = true;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			target = null;
			targetLocked = false;
		}
	}
}
