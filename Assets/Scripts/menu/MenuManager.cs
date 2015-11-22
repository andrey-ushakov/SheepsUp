using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	public Texture button;
	public GUIStyle mystyle;

	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	void OnGUI() {
		Camera camera = Camera.main;
		Vector3 p1 = camera.ViewportToScreenPoint (new Vector3 (0.5f, 0.5f, 1f));
		Vector3 size = camera.ViewportToScreenPoint (new Vector3 (0.2f, 0.2f, 1f));
		
		Debug.Log (p1);
		
		if (GUI.Button (new Rect (p1.x-size.x/2, p1.y, size.x, size.y), button, mystyle)) {
			Play();
		}
	}
	
	void Update () {
	
	}


	public void Play () {
		Application.LoadLevel("game");
	}

}
