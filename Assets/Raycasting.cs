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
	public GameObject _cube;
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
		} else if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Inventory" && inventorybehaviour._getItems[itemname] > 0 && Input.GetMouseButtonDown(0)){
			inventorybehaviour.GetItem (itemname, amountOfObjectsRetrieved);
		}
	}
	public void GotItem(string item, int amount){
		if (item == itemname) {
			for (int i = 0; i < amount; i++) {
				j++;
				Instantiate (_cube, new Vector3(j + 19,0,-8), Quaternion.identity);
			}
		}
	}
}
