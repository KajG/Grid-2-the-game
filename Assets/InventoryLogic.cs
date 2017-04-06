using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryLogic : MonoBehaviour {

	public List<Image> _slotImage = new List<Image> ();
	public List<Button> _buttonSlots = new List<Button> ();
	public List<List<GameObject>> _slots = new List<List<GameObject>>();
	public int _index;
	public int _openSlotIndex;
	public int _slotCount;
	public int spawnXOffset;
	public int spawnYOffset;
	public bool itemAdded;
	public string _itemName;
	public Sprite _placeHolder;
	public List<int> _openSlots = new List<int> ();
	public List<int> _usedSlots = new List<int> ();
	public List<int> _sameObj = new List<int> ();
	void Start () {
		for (int i = 0; i < _slotCount; i++) {
			_slots.Add (new List<GameObject> ());
		}
	}
	
	void Update () {
		print (_slots[2].Count);
	}
	void CheckSlots(GameObject item){
		_sameObj.Clear();
		_usedSlots.Clear ();
		_openSlots.Clear ();
		_itemName = item.name;
		for (int i = 0; i < _slots.Count; i++) {
			if(_slots[i].Count > 0){
				if (_slots [i][0].name == _itemName) {
					_sameObj.Add (i);
				}
			} else if(_slots[i].Count <= 0) {
				_openSlots.Add (i);
			}
			if (_slots [i].Count > 0 && _slots[i][0].name == _itemName) {
				_usedSlots.Add (i);
			} 
		}
		AddItem (item);
	}
	void AddItem(GameObject item){
		if (_sameObj.Count > 0) {
			_slots [_sameObj [0]].Add (item);
		} else {
			_slots [_openSlots [0]].Add (item);
			_slotImage [_openSlots [0]].sprite = item.GetComponent<Image> ().sprite;
		}
	}
	public void OnButtonPress(int index){
		if (_slots [index].Count <= 0) {
			return;
		}
		_slots [index] [0].SetActive (true);
		GameObject obj = Instantiate (_slots [index][0], new Vector3(transform.position.x + spawnXOffset, transform.position.y + spawnYOffset, transform.position.z), Quaternion.identity);
		obj.name = _slots [index] [0].name;
		Destroy (_slots [index][0]);
		_slots [index].RemoveAt (0);
		if (_slots [index].Count <= 0) {
			_slotImage [index].sprite = _placeHolder;
		}
	}
	void OnTriggerEnter(Collider item){
		if (item.gameObject.tag == "Item") {
			CheckSlots (item.gameObject);	
			item.gameObject.SetActive (false);
		}
	}
}
