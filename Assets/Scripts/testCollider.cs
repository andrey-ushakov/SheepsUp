using UnityEngine;
using System.Collections;

public class testCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("YOYOYOY");
		Destroy(other.gameObject);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
