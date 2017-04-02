using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	
	public Transform dude;
	public float yOffset;

	void Start () {
		
	}
	
	void Update () {
		transform.position = new Vector3(dude.position.x, dude.position.y + yOffset, dude.position.z);
	}
}
