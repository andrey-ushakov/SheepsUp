using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public float dreamStatus;
	public float timer;
	public bool gameOver;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		dreamStatus = 1f;
		gameOver = false;
		timer = 0;
	}

	void OnEnable(){
		SheepManager.sheepDie += sheepDieHandler;
	}

	// Update is called once per frame
	void Update () {
		if (gameOver == false) {
			timer += Time.deltaTime;
			if (dreamStatus < 1)
				dreamStatus += 0.025f * Time.deltaTime;
		}
	}

	void sheepDieHandler(object sender){
		dreamStatus -= 0.2f;
	}

	public string getTime(){
		int min = 0;
		int sec = 0;
		string time = "";
		min = ((int)timer )/ 60;
		sec = ((int)timer) % 60;
		if (min < 10) {
			time += "0";
		}
		time += min;
		time += ":";
		if (sec < 10) {
			time += "0";
		}
		time += sec;
		return time;
	}


}
