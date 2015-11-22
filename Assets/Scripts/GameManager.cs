using System;
using UnityEngine;
using System.Collections;

public delegate void GameOverEventHandler(object sender, GameOverEventArgs args);

public class GameOverEventArgs: EventArgs{
	public string score = "";
}

public class GameManager : MonoBehaviour {
	public static event GameOverEventHandler gameOverEvent;

	public float dreamStatus;
	public float timer;
	public bool gameOver;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	void OnEnable(){
		SheepManager.sheepDie += sheepDieHandler;
	}

	void OnDisable(){
		SheepManager.sheepDie -= sheepDieHandler;
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
		if (dreamStatus <= 0.2) {
			dreamStatus = 0;
			gameOver = true;
			OnGameOver(getTime());
		}
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

	protected virtual void OnGameOver(string score) {
		GlobalVariables.score = score;
		Application.LoadLevel("game_over");

		if (gameOverEvent != null) {
			GameOverEventArgs a = new GameOverEventArgs();
			a.score = score;
			gameOverEvent(this, a);
		}
	}
	
	
}
