using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public float dreamStatus;
	public float timer;
	public bool gameOver;

	// Use this for initialization
	void Start () {
		dreamStatus = 1f;
		gameOver = false;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == false) {
			timer += Time.deltaTime;
			dreamStatus += 0.05f * Time.deltaTime;
		}
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
