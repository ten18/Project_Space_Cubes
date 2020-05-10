using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour {

	// Use this for initialization
	public GameObject blockPrefab;
	public GameObject _block;
	public bool triggered;
	public int blockCount = 0;

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player" && blockCount <= 0)
		{
			// spawn a block
			Instantiate(blockPrefab.transform, transform.position, Quaternion.identity);
			_block = GameObject.Find("Ramp Block(Clone)");
			// tick up the spawn counter
			blockCount++;
			// start the countdown
			StartCoroutine(BlockDestructCount());
		}
	}
	IEnumerator BlockDestructCount()
	{
		yield return new WaitForSeconds(10);
		Destroy(_block);
		blockCount--;
	}

	// Update is called once per frame
	void Update () {

	}
}
