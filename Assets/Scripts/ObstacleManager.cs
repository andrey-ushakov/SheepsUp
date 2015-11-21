using UnityEngine;
using System.Collections;

public class ObstacleManager : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("The fucking sheep touch the obstacle");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
