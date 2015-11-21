using UnityEngine;
using System.Collections;

public class PatternManagerLayout1 : PatternManager {

	// Use this for initialization
	void Start () {
		period = 30 / (GlobalVariables.layout1Speed);
		curTime	= period;
		generateTime = period - 1;
		generateGrass(_generateInitPos);
	}
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
}
