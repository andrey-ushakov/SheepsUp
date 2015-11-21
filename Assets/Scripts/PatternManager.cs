using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PatternManager : MonoBehaviour {

	[SerializeField]
	private GameObject _grass;

	[SerializeField]
	List<GameObject> obstacles = new List<GameObject>();

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

		Vector3 p = camera.ViewportToWorldPoint(new Vector3(pos, 0.15f, camera.nearClipPlane));
		p.x += 1;
		p.y += 1;

		// grass
		Vector3 p1 = new Vector3(p.x, p.y, p.z);
		GameObject.Instantiate(_grass, p1, Quaternion.identity);

		// obstacle
		/*GameObject ob1 = obstacles[Random.Range (0, 2)];
		Vector3 p2 = new Vector3(p.x + 6, p.y, p.z);
		GameObject.Instantiate(ob1, p2, Quaternion.identity);

		// grass
		Vector3 p3 = new Vector3(p.x + 8, p.y, p.z);
		GameObject.Instantiate(_grass, p3, Quaternion.identity);

		// obstacle
		GameObject ob2 = obstacles[Random.Range (0, 2)];
		Vector3 p4 = new Vector3(p.x + 14, p.y, p.z);
		GameObject.Instantiate(ob2, p4, Quaternion.identity);

		// grass
		Vector3 p5 = new Vector3(p.x + 16, p.y, p.z);
		GameObject.Instantiate(_grass, p5, Quaternion.identity);

		// obstacle
		GameObject ob3 = obstacles[Random.Range (0, 2)];
		Vector3 p6 = new Vector3(p.x + 22, p.y, p.z);
		GameObject.Instantiate(ob3, p6, Quaternion.identity);

		
		// grass
		Vector3 p7 = new Vector3(p.x + 24, p.y, p.z);
		GameObject.Instantiate(_grass, p7, Quaternion.identity);*/


		/*for(int i = 0 ; i<5; ++i) {
			Vector3 p = camera.ViewportToWorldPoint(new Vector3(pos, 0.2f, camera.nearClipPlane));
			p.x += 1;
			p.y += 1;

			Vector3 p1 = new Vector3(p.x + i*6, p.y, p.z);
			GameObject.Instantiate(_grass, p1, Quaternion.identity);
		}*/
	}

}
