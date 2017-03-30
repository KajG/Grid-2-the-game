using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyItself : MonoBehaviour {
	public GameObject me;
	void Start () {
		me = Instantiate (me, me.transform.position, Quaternion.identity);
		me.name = "Cylinder";
	}
	
	void Update () {
		
	}
}
