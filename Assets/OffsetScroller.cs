using UnityEngine;
using System.Collections;

public class OffsetScroller : MonoBehaviour {

	[SerializeField]
	private float speed = 0.5f;


	void Start () {
	}

	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}



	/*public float scrollSpeed;
	private Vector2 savedOffset;
	
	void Start () {
		savedOffset = GetComponent<Renderer>().sharedMaterial.GetTextureOffset ("layout1");
	}
	
	void Update () {
		float y = Mathf.Repeat (Time.time * scrollSpeed, 1);
		Vector2 offset = new Vector2 (savedOffset.x, y);
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("layout1", offset);
	}
	
	void OnDisable () {
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("layout1", savedOffset);
	}*/
}
