using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Vector3 forward;
	public Vector3 backward;
	public Vector3 left;
	public Vector3 right;
	public float speed;

	void Start () {
		forward = new Vector3 (0, 0, speed);
		backward = new Vector3 (0, 0, -speed);
		left = new Vector3 (-speed, 0, 0);
		right = new Vector3 (speed, 0, 0);
	}
	
	void Update () {
		transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);
		if (Input.GetKey (KeyCode.W)) {
			transform.position += (transform.forward  * Time.fixedDeltaTime) * speed;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position -= (transform.forward  * Time.fixedDeltaTime) * speed;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position -= (transform.right * Time.fixedDeltaTime) * speed;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += (transform.right  * Time.fixedDeltaTime) * speed;
		}
	}
}
