using UnityEngine;
using System.Collections;

public class PatternManagerLayout1 : PatternManager {

	// Use this for initialization
	void Start () {
		period = 45 / (GlobalVariables.layout1Speed);
		curTime	= period;
		generateTime = period;
		generateGrass(_generateInitPos);
	}
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
}
