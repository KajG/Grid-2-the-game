using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour {

	public static Dictionary<string, int> _items = new Dictionary<string, int> ();
	public Dictionary<string, int> _getItems{get{return _items;} set{_items = value;}}
	public Raycasting raycasting;
	private int j;
	public GameObject _cube;

	void Start () {
		raycasting = raycasting.GetComponent<Raycasting> ();
	}
	void Update(){
		//print (_items["Cube(clone)"]);
	}
	public void AddItem(string item, int amount){
		if (_items.ContainsKey (item)) {
			_items [item]++; 
		} else {
			_items.Add (item, amount);
		}
		print (_items["Cube(Clone)"]);
	}
	public void GetItem(string item, int amount){
		if (_items [item] <= 0) {
			_items.Remove (item);
		} else {
			for (int i = 0; i < amount; i++) {
				Instantiate (_cube, new Vector3(j + 19,0,-8), Quaternion.identity);
			}
			_items [item] -= amount;
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
	void OnTriggerEnter(Collider other){
		AddItem (other.gameObject.name, 1);
		Destroy (other.gameObject);
	}
}
