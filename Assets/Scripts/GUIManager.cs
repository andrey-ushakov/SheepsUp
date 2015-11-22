using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
	public GameManager gm;
	float dreamStatus;
	int score;

	public Texture bar_broder;
	public Texture bar_content;
	public Texture bar_pin;

	GUIStyle style;
	Font myFont;

	// Use this for initialization
	void Awake(){
		gm = gameObject.GetComponent<GameManager> ();
	}

	void Start () {
		style = new GUIStyle();
		myFont = (Font)Resources.Load("Fonts/snaphand", typeof(Font));
		style.fontSize = 36;
		style.font = myFont;

		dreamStatus = gm.dreamStatus;


		dreamStatus = 1f;
	}

	void OnGUI() {
		Camera camera = Camera.main;

		Vector3 position = camera.ViewportToScreenPoint (new Vector3 (0.5f, 0.1f, 1f));
		Vector3 size = camera.ViewportToScreenPoint (new Vector3 (0.4f, 0.1f, 1f));

		DrawProgress (position.x, position.y, size.x, size.y, 1f);

		position = camera.ViewportToScreenPoint (new Vector3 (0.1f, 0.1f, 1f));
		size = camera.ViewportToScreenPoint (new Vector3 (0.2f, 0.2f, 1f));

		DrawScore (position.x, position.y, size.x, size.y, "test 01231");

	}

	// Update is called once per frame
	void Update () {
		dreamStatus -= 0.3f * Time.deltaTime;
		if (dreamStatus <= 0.1)
			dreamStatus = 1f;
		
	}

	void DrawProgress(float x, float y, float l, float h, float progress)
	{
		GUI.DrawTexture(new Rect(x + l/7, y+ h/3, l - l/7, h/3), bar_content);
		GUI.DrawTexture(new Rect(x, y, l, h), bar_broder);
		GUI.DrawTexture (new Rect (x + l / 7f + (l * 0.84f)  * progress, y, l / 50, h), bar_pin);
	}

	void DrawScore(float x, float y, float l, float h, string text){
		GUI.Label (new Rect (x, y, l, h), text, style);
	}
}
