using UnityEngine;
using System.Collections;

public class Layer3Movement : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		float x = this.transform.position.x - GlobalVariables.layout3Speed * Time.deltaTime;
		this.transform.position = new Vector3(x, this.transform.position.y, this.transform.position.z);
		
		if (x < -70) {
			Destroy(this);
		}
	}
}
