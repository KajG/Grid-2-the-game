using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour {

	public static Dictionary<string, int> _items = new Dictionary<string, int> ();
	public Raycasting raycasting;

	void Start () {
		raycasting = raycasting.GetComponent<Raycasting> ();
	}
	void Update(){
		print (_items ["Cube(Clone)"]);
	}
	public void AddItem(string item, int amount){
		if (_items.ContainsKey (item)) {
			_items [item]++; 
		}
		_items.Add (item, amount);
	}
	public void GetItem(string item, int amount){
		raycasting.GotItem (item, amount);
		if (_items [item] < 0) {
			_items.Remove (item);
		} else {
			_items [item] -= amount;
		}
	}
	void OnTriggerEnter(Collider other){
		AddItem (other.gameObject.name, 1);
		Destroy (other.gameObject);
	}
}
