using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour {

	public static Dictionary<string, List<GameObject>> _items = new Dictionary<string, List<GameObject>> ();
	public Dictionary<string, List<GameObject>> _getItems{get{return _items;} set{_items = value;}}
	public List <GameObject> _objects = new List<GameObject>();
	public Raycasting raycasting;
	public GameObject previewItem;
	public GameObject _cube;
	public TextMesh _itemCount;
	public string itemname;
	private int j;

	void Start () {
		raycasting = raycasting.GetComponent<Raycasting> ();
	}
	public void AddItem(string itemname, GameObject obj){
		if (_items.ContainsKey (itemname)) {
			_items[itemname].Add(obj); 
			print (_items[itemname].Count);
		} else {
			_items.Add(itemname, new List<GameObject>());
			ItemPreview (obj);
			_items[itemname].Add(obj); 
			print (_items[itemname].Count);
		}
		UpdateItemCounter (itemname);
	}
	public void GetItem(string itemname, int amount){
		for (int i = 0; i < amount; i++) {
			j++;	
			GameObject obj = Instantiate (_items [itemname][0], new Vector3 (j + 19, 0, -8), Quaternion.identity);
			obj.name = (itemname);
			Destroy (_items [itemname] [0]);
			_items [itemname].RemoveAt (0);
			UpdateItemCounter (itemname);
				if (_items [itemname].Count <= 0) {
					_items.Remove (itemname);
					ItemPreviewRemove ();
				}
		}
	}
	void ItemPreview(GameObject obj){
		previewItem = Instantiate (obj, new Vector3 (transform.position.x, transform.position.y, -11), Quaternion.identity);
	}
	void ItemPreviewRemove(){
		Destroy (previewItem);
	}
	void UpdateItemCounter(string itemname){
		_itemCount.text = ("" + _items [itemname].Count);
	}
	void OnTriggerEnter(Collider other){
		AddItem (other.gameObject.name, other.gameObject);
	}
}
