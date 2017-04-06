using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawn : MonoBehaviour {

	public GameObject item;
	public GameObject item2;
	public GameObject item3;
	public int spawnAmount;

	void Start () {
		for (int i = 0; i < spawnAmount; i++) {
			int randNumb = Random.Range (0, 4);
			if (randNumb == 1) {
				Instantiate (item, new Vector3 (i, 0, 0), Quaternion.identity);
			} else if (randNumb == 2) {
				Instantiate (item2, new Vector3 (0, 0, i), Quaternion.identity);
			} else {
				Instantiate (item3, new Vector3 (i, 0, i), Quaternion.identity);
			}
		}
	}
	
	void Update () {
		
	}
}
