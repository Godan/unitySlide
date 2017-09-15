using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour {

	public GameObject[] images;
	public int idx = 0;
	private GameObject obj;
	// Use this for initialization
	void Start () {
	}

	
	// Update is called once per frame
	void Update () {
		Debug.Log (idx + ":");

		if (images.Length > idx && images [idx] != null) {
			Vector3 point = transform.position;
			point = new Vector3 (point.x, point.y, point.z);
			Destroy (obj);
			obj  = Instantiate (images [idx], point, transform.rotation);
		}
	
		
	}

	public void add(){
		if (idx < images.Length) {
			idx += 1;
		}
	}

	public void sub(){
		if (0 < idx) {
			idx -= 1;
		}
	}

	private void destroys(int idx){
		
	}
}
