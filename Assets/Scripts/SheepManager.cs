using UnityEngine;
using System.Collections;

public class SheepManager : MonoBehaviour {
	public Rigidbody2D rb;

	void OnEnable() {
		InputManager.buttonAClicked += jump;
	}

	void Disable() {
		InputManager.buttonAClicked -= jump;
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void comeToScreen(){

	}

	void jump(object sender){
		rb.AddForce(new Vector2(0,10), ForceMode2D.Impulse);
	}
	
}
