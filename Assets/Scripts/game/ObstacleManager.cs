﻿using UnityEngine;
using System.Collections;

public class ObstacleManager : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		SheepManager sm = other.GetComponent<SheepManager> ();
		sm.die ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
