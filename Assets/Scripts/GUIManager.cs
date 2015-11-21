﻿using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
	public GameManager gm;
	float dreamStatus;
	int score;

	public Texture bar_broder;
	public Texture bar_content;
	public Texture bar_pin;

	// Use this for initialization
	void Awake(){
		gm = gameObject.GetComponent<GameManager> ();
	}

	void Start () {
		dreamStatus = gm.dreamStatus;
		score = gm.score;
	}

	void OnGUI() {
		Camera camera = Camera.main;

		Vector3 position = camera.ViewportToScreenPoint (new Vector3 (0.6f, 0.1f, 1f));
		Vector3 size = camera.ViewportToScreenPoint (new Vector3 (0.4f, 0.1f, 1f));

		DrawProgress (position.x, position.y, size.x, size.y, 0.6f);

	}

	// Update is called once per frame
	void Update () {
		
	}

	void DrawProgress(float x, float y, float l, float h, float progress)
	{
		GUI.DrawTexture(new Rect(x + l/7, y+ h/3, l * progress, h/3), bar_content);
		GUI.DrawTexture(new Rect(x, y, l, h), bar_broder);
	}
}
