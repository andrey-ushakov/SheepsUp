using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	[SerializeField]
	public Texture button;
	[SerializeField]
	public GUIStyle mystyle;

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
		GUI.Label (new Rect (x, y, l, h), text, style);
	}


	void OnGUI() {
		Camera camera = Camera.main;
		Vector3 position = camera.ViewportToScreenPoint (new Vector3 (0.5f, 0.65f, 1f));
		Vector3 size = camera.ViewportToScreenPoint (new Vector3 (0.15f, 0.15f, 1f));
		DrawFinalTime (position.x - size.x/2, position.y, size.x, size.y, GlobalVariables.score);


		Vector3 p1 = camera.ViewportToScreenPoint (new Vector3 (0.5f, 0.8f, 1f));
		Vector3 size1 = camera.ViewportToScreenPoint (new Vector3 (0.2f, 0.2f, 1f));

		if (GUI.Button (new Rect (p1.x - size1.x/2, p1.y, size1.x, size1.y), button, mystyle)) {
			Play();
		}
	}

	public void Play () {
		Application.LoadLevel("game");
	}

}
