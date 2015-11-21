using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public delegate void ButtonAClickedEventHandler(object sender);
public delegate void ButtonBClickedEventHandler(object sender);

public class InputManager : MonoBehaviour {

	public static event ButtonAClickedEventHandler buttonAClicked;
	public static event ButtonBClickedEventHandler buttonBClicked;

	void OnGUI() {
		Camera camera = GetComponent<Camera>();
		Vector3 p1 = camera.ViewportToScreenPoint (new Vector3 (0.1f, 0.8f, 1f));
		Vector3 p2 = camera.ViewportToScreenPoint (new Vector3 (0.8f, 0.8f, 1f));

		//Button buttonA = 
		if (GUI.Button (new Rect (p1.x, p1.y, 100, 100), "A button")) {
			OnButtonAClicked();
		}
		//Button buttonB = 
		if (GUI.Button (new Rect (p2.x, p2.y, 100, 100), "B button")){
			OnButtonBClicked();
		}


	}


	public void OnButtonAClicked(){
		Debug.Log ("ButtonA clicked!!!!");
		if (buttonAClicked != null)
		{
			buttonAClicked(this);
		}
	}

	public void OnButtonBClicked(){
		if (buttonBClicked != null)
		{
			buttonBClicked(this);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//public Texture btnTexture;

}
