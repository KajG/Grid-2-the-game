using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Raycasting : MonoBehaviour {
	private RaycastHit hit;
	private Ray ray;
	private Vector3 mousePos;
	public InventoryBehaviour inventorybehaviour;
	public string itemname;
	public int amountOfObjectsRetrieved;
	public List<GameObject> _cubes;
	private int j;
	void Start(){
		inventorybehaviour = inventorybehaviour.GetComponent<InventoryBehaviour> ();
	}
	void Update () {
		mousePos = Input.mousePosition;
		mousePos.z = 10;
		mousePos = Camera.main.ScreenToWorldPoint (mousePos);
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Item") {
			hit.transform.position = mousePos;
		} else if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Inventory" && Input.GetMouseButtonDown(0)){
			inventorybehaviour.GetItem (itemname, amountOfObjectsRetrieved);
		}
	}
}
