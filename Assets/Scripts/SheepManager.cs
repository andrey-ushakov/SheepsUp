using UnityEngine;
using System.Collections;

public class SheepManager : MonoBehaviour {
	public Rigidbody2D rb;
	public Animator am;

	void OnEnable() {
		InputManager.buttonAClicked += jump;
	}

	void Disable() {
		InputManager.buttonAClicked -= jump;
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		am = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void comeToScreen(){

	}

	void jump(object sender){
		am.Play ("Jump_In");
		rb.AddForce(new Vector2(0,14), ForceMode2D.Impulse);
	}
	
}
