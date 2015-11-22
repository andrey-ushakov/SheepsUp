using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	GUIStyle style;
	Font myFont;

	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;

		style = new GUIStyle();
		myFont = (Font)Resources.Load("Fonts/comix", typeof(Font));
		style.fontSize = 36;
		style.normal.textColor = Color.white;
		style.font = myFont;
	}
	
	void Update () {
	}


	void DrawFinalTime(float x, float y, float l, float h, string text){
		GUI.Label (new Rect (x - l/2, y, l, h), text, style);
	}


	void OnGUI() {
		Camera camera = Camera.main;
		Vector3 position = camera.ViewportToScreenPoint (new Vector3 (0.5f, 0.7f, 1f));
		Vector3 size = camera.ViewportToScreenPoint (new Vector3 (0.1f, 0.1f, 1f));
		DrawFinalTime (position.x, position.y, size.x, size.y, "1:11");
	}

	/*bool isFalling = false;

	[SerializeField]
	private float speed = 0.5f;
	[SerializeField]
	GameObject gameOverTexture;

	void OnEnable() {
		GameManager.gameOverEvent += OnGameOver;
	}
	
	void OnDisable() {
		GameManager.gameOverEvent -= OnGameOver;
	}


	void Start () {
	
	}

	void Update () {
		if (isFalling) {
			Debug.Log ("Fall");
			if (gameOverTexture.transform.position.y > 0) {
				Debug.Log ("Move");
				Vector3 p = gameOverTexture.transform.position;
				p.y -= Time.deltaTime * speed;
				gameOverTexture.transform.position = p;
			} else {
			}
		}
	}


	void OnGameOver(object sender, GameOverEventArgs args) {
		Debug.Log (args.score);
		isFalling = true;
	}*/


}
