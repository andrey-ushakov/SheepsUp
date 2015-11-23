using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
	public GameManager gm;
	float dreamStatus;
	int score;

	public Texture bar_broder;
	public Texture bar_pin;

	GUIStyle style;
	Font myFont;

	// Use this for initialization
	void Awake(){
		gm = gameObject.GetComponent<GameManager> ();
	}

	void Start () {
		style = new GUIStyle();
		myFont = (Font)Resources.Load("Fonts/comix", typeof(Font));
		style.fontSize = 36;
		style.font = myFont;

		dreamStatus = gm.dreamStatus;


		dreamStatus = 1f;
	}

	void OnGUI() {
		Camera camera = Camera.main;

		Vector3 position = camera.ViewportToScreenPoint (new Vector3 (0.27f, 0.83f, 1f));
		Vector3 size = camera.ViewportToScreenPoint (new Vector3 (0.46f, 0.1f, 1f));

		DrawProgress (position.x, position.y, size.x, size.y, gm.dreamStatus);

		position = camera.ViewportToScreenPoint (new Vector3 (0.1f, 0.1f, 1f));
		size = camera.ViewportToScreenPoint (new Vector3 (0.3f, 0.3f, 1f));

		DrawScore (position.x, position.y, size.x, size.x, gm.getTime());

	}

	// Update is called once per frame
	void Update () {
		
	}

	void DrawProgress(float x, float y, float l, float h, float progress)
	{
		GUI.DrawTexture(new Rect(x, y, l, h), bar_broder);
		GUI.DrawTexture (new Rect (x + l / 7f + (l * 0.70f)  * progress, y, l / 50, h), bar_pin);
	}

	void DrawScore(float x, float y, float l, float h, string text){
		GUI.Label (new Rect (x, y, l, h), text, style);
	}
}
