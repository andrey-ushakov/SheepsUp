using UnityEngine;
using System.Collections;

public class PatternManager : MonoBehaviour {

	[SerializeField]
	private GameObject _grass;

	//[SerializeField]
	//private float grassSpeed = 1.2f;

	private float period;
	private float curTime = 0;
	private float generateTime;


	void Start () {
		period = 30 / (GlobalVariables.grassSpeed);
		curTime	= period;
		generateTime = period - 1;
		generateGrass(0);
	}

	void Update () {
		//Grass generation
		if(curTime >= generateTime) {
			// TODO generate grass
			generateGrass(1);
			generateTime += period - 1;
		}
		curTime += Time.deltaTime;
	}


	void generateGrass(int pos) {
		Camera camera = Camera.main;
		for(int i = 0 ; i<5; ++i) {
			Vector3 p = camera.ViewportToWorldPoint(new Vector3(pos, 0, camera.nearClipPlane));
			p.x += 1;
			p.y += 1;

			Vector3 p1 = new Vector3(p.x + i*6, p.y, p.z);
			//Debug.Log (p1);

			GameObject.Instantiate(_grass, p1, Quaternion.identity);
		}



	}

}
