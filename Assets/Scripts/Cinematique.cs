using UnityEngine;
using System.Collections;

public class Cinematique : MonoBehaviour {
	
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float zoom = 10f;

	void Start () {
	
	}
	
	void Update () {
		if (transform.position.x > -7.45) {
			Vector3 pos = transform.position;
			pos.x -= speed * Time.deltaTime;
			transform.position = pos;
		} else {
			if(Camera.main.fieldOfView > 12) {
				Camera.main.fieldOfView -= zoom * Time.deltaTime;
			} else {
				Application.LoadLevel("menu");
			}
		}
	}
}
