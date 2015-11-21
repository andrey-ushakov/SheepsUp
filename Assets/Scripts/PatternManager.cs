using UnityEngine;
using System.Collections;

public class PatternManager : MonoBehaviour {

	[SerializeField]
	private GameObject _grass;
	
	void Start () {
		Camera camera = Camera.main;
		Vector3 p = camera.ViewportToWorldPoint(new Vector3(0, 0, camera.nearClipPlane));
		p.x += 1;
		p.y += 1;

		GameObject.Instantiate(_grass, p, Quaternion.identity);
	}

	void Update () {
	
	}
}
