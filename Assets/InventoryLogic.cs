using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryLogic : MonoBehaviour {

	public List<Image> _slotImage = new List<Image> ();
	public List<List<GameObject>> _slots = new List<List<GameObject>>();
	public int _index;
	public int _openSlotIndex;
	public int _slotCount;
	public bool itemAdded;
	public List<int> _openSlots = new List<int>();
	void Start () {
		for (int i = 0; i < _slotCount; i++) {
			_slots.Add (new List<GameObject> ());
		}
	}
	
	void Update () {
		print (_slots[0].Count);
	}
	void AddItem(GameObject item){

	}
	void OnTriggerEnter(Collider item){
		if (item.gameObject.tag == "Item") {
			AddItem (item.gameObject);		
		}
	}
}
/*if(_slots [_index].Contains (item)){
	ExistingItem(item);
	return;
}*/
