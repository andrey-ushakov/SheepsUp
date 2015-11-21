using UnityEngine;
using System.Collections;

public class SheepManager : MonoBehaviour {
	public int sheepType = 0; //1 = black, 2 = white
	public Rigidbody2D rb;
	public Animator am;

	void OnEnable() {
		if (this.sheepType == 1) {
			InputManager.buttonAClicked += jump;
		}
		else if (this.sheepType == 2) {
			InputManager.buttonBClicked += jump;
		}
	}

	void Disable() {
		if (this.sheepType == 1) {
			InputManager.buttonAClicked -= jump;
		}
		else if (this.sheepType == 2) {
			InputManager.buttonBClicked -= jump;
		}
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

	public void die(){
		am.Play ("Destruction");
	}

	void jump(object sender){
		am.Play ("Jump_In");
		rb.AddForce(new Vector2(0,14), ForceMode2D.Impulse);
	}
	
}
