using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaking : MonoBehaviour {
	[SerializeField]private GameObject _cube;
	[SerializeField]private GameObject _cylinder;
	[SerializeField]private List<GameObject> _objs = new List<GameObject> ();
	[SerializeField]private int yAmount;
	[SerializeField]private int xAmount;
	void Start () {
		for (int y = 0; y < yAmount; y++) {
			for (int x = 0; x < xAmount; x++) {
				int random = Random.Range (0, 2);
				if (random == 0) {
					GameObject _cubeInst = Instantiate (_cube, new Vector3 (x, y, 0), Quaternion.identity);
					_cubeInst.name = _cube.name;
					_objs.Add (_cubeInst);
				} else {
					GameObject _cylinderInst = Instantiate (_cylinder, new Vector3 (x, y, 0), Quaternion.identity);
					_cylinderInst.name = _cylinder.name;
					_objs.Add (_cylinderInst);
				}
			}
		}
	}
}
