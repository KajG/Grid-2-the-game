using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour {

	public int rotSpeed = 1;
	void Start () {

	}

	void Update () {
		Vector3 rot = new Vector3 (0, rotSpeed, 0);
		transform.eulerAngles += rot;
	}
}
