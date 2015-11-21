using UnityEngine;
using System.Collections;

public class SheepManager : MonoBehaviour {
	Vector3 pos = new Vector3(0,0,0);
	float accY;
	float speedY;
	float landY;
	

	void OnEnable() {
		InputManager.buttonAClicked += jump;
	}

	void Disable() {
		InputManager.buttonAClicked -= jump;
	}

	// Use this for initialization
	void Start () {
		accY = -0.5f;
		speedY = 0f;

		Camera camera = Camera.main;
		Vector3 p = camera.ViewportToWorldPoint(new Vector3(0.15f, 0.15f, camera.nearClipPlane));
		pos.x = p.x;
		pos.y = p.y;
		pos.z = p.z;
		gameObject.transform.position = pos;
		landY = pos.y;

	}
	
	// Update is called once per frame
	void Update () {
		if (pos.y > landY || speedY == 15) {
			speedY += accY;
			pos.y += speedY * Time.deltaTime;
			gameObject.transform.position = pos;
			Debug.Log (speedY);
		} else {
			speedY = 0;
		}
	}

	void comeToScreen(){

	}

	void jump(object sender){
		if (pos.y > landY)
			return;
		speedY = 15;
		Debug.Log (speedY);
	}
	
}
