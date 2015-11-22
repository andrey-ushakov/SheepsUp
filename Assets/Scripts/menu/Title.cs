using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	[SerializeField]
	private float _x = 0.5f;
	[SerializeField]
	private float _y = 0.5f;
	[SerializeField]
	private float _z = 9;

	// Use this for initialization
	void Start () {
		Vector3 p = Camera.main.ViewportToWorldPoint (new Vector3(_x, _y, _z));
		this.transform.position = p;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
