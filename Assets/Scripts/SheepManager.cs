﻿using UnityEngine;
using System.Collections;

public delegate void SheepDieEventHandler(object sender);

public class SheepManager : MonoBehaviour {

	public static event SheepDieEventHandler sheepDie;

	public int sheepType = 0; //1 = black, 2 = white
	public Rigidbody2D rb;
	public Animator am;
	public GameManager gm;

	float blackSheepArrivePos;
	float whiteSheepArrivePos;
	Vector3 speed;
	Vector3 blackInitPos;
	Vector3 whiteInitPos;

	public bool arrive;

	void EnableInput() {
		if (this.sheepType == 1) {
			InputManager.buttonAClicked += jump;
		}
		else if (this.sheepType == 2) {
			InputManager.buttonBClicked += jump;
		}
	}

	void DisableInput() {
		if (this.sheepType == 1) {
			InputManager.buttonAClicked -= jump;
		}
		else if (this.sheepType == 2) {
			InputManager.buttonBClicked -= jump;
		}
	}

	void Awake() {
		Camera camera = Camera.main;
		speed = camera.ViewportToWorldPoint (new Vector3 (0.7f, 0.5f, 0f));
		speed.z = 0f;
		Vector3 position1 = camera.ViewportToWorldPoint (new Vector3 (0.2f, 0.2f, 1f));
		Vector3 position2 = camera.ViewportToWorldPoint (new Vector3 (0.4f, 0.2f, 1f));
		blackInitPos = camera.ViewportToWorldPoint (new Vector3 (0.0f, 0.25f, 7f));
		whiteInitPos = camera.ViewportToWorldPoint (new Vector3 (0.1f, 0.25f, 7f));

		blackSheepArrivePos = position1.x;
		whiteSheepArrivePos = position2.x;
		if (sheepType == 1) {
			gameObject.transform.position = blackInitPos;
		} else if (sheepType == 2) {
			gameObject.transform.position = whiteInitPos;
		}

	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		am = GetComponent<Animator> ();

		arrive = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!arrive) {
			comeToScreen();
		}

	}

	void comeToScreen(){
		switch (sheepType) {
		case 1:
			if (transform.position.x >= blackSheepArrivePos){
				arrive = true;
				EnableInput();
				enableSelf();
				return;
			}
			break;
		case 2:
			if (transform.position.x >= whiteSheepArrivePos){
				arrive = true;
				EnableInput();
				enableSelf();
				return;
			}
			break;
		}

		gameObject.transform.position += speed * Time.deltaTime;
	}

	public void die(){
		sheepDie (this);
		am.Play ("Destruction");
		DisableInput ();
		Invoke ("disableSelf", 2.5f);
		Invoke ("relife", 4.0f);
	}

	public void relife(){
		am.Play ("Marche");
		gameObject.transform.position = blackInitPos;
		arrive = false;
	}

	public void disableSelf(){
		BoxCollider2D[] colliders = gameObject.GetComponents<BoxCollider2D> ();
		foreach (BoxCollider2D collider in colliders) {
			collider.enabled = false;
		}
		Rigidbody2D rigdbody = gameObject.GetComponent<Rigidbody2D> ();
		rigdbody.gravityScale = 0;
	}

	public void enableSelf(){
		BoxCollider2D[] colliders = gameObject.GetComponents<BoxCollider2D> ();
		foreach (BoxCollider2D collider in colliders) {
			collider.enabled = true;
		}
		Rigidbody2D rigdbody = gameObject.GetComponent<Rigidbody2D> ();
		rigdbody.gravityScale = 2;
	}

	void jump(object sender){

		am.Play ("Jump_In");
		rb.AddForce(new Vector2(0,14), ForceMode2D.Impulse);
	}
	
}
