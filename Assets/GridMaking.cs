using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaking : MonoBehaviour {
	[SerializeField]private GameObject _cube;
	[SerializeField]private List<GameObject> _cubes = new List<GameObject> ();
	[SerializeField]private int yAmount;
	[SerializeField]private int xAmount;
	void Start () {
		for (int y = 0; y < yAmount; y++) {
			for (int x = 0; x < xAmount; x++) {
				GameObject _cubeInst = Instantiate(_cube, new Vector3(x, y, 0), Quaternion.identity);
				_cubes.Add (_cubeInst);
			}
		}
	}
}
