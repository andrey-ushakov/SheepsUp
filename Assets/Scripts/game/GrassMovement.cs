using UnityEngine;
using System.Collections;

public class GrassMovement : MonoBehaviour {

	void Start () {
	}
	
	void Update () {
		float x = this.transform.position.x - GlobalVariables.grassSpeed * Time.deltaTime;
		this.transform.position = new Vector3(x, this.transform.position.y, this.transform.position.z);

		if (x < -70) {
			Destroy(this);
		}
	}
}
