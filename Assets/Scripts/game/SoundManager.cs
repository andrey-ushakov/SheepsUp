using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	public AudioSource AS;
	public AudioClip die;
	public AudioClip buttonTouch;
	public AudioClip jump;

	void Awake() {
		AS = gameObject.GetComponent<AudioSource> ();
	}

	void OnEnable(){
		InputManager.buttonAClicked += playButtonTouch;
		InputManager.buttonBClicked += playButtonTouch;
		SheepManager.sheepJump += playJump;
		SheepManager.sheepDie += playDie;
	}

	void OnDisable(){
		InputManager.buttonAClicked -= playButtonTouch;
		InputManager.buttonBClicked -= playButtonTouch;
		SheepManager.sheepJump -= playJump;
		SheepManager.sheepDie -= playDie;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void playJump(object sender){
		AS.PlayOneShot (jump);
	}

	void playDie(object sender){
		AS.PlayOneShot (die);
	}

	void playButtonTouch(object sender){
		AS.PlayOneShot (buttonTouch);
	}
}
