using UnityEngine;
using System.Collections;

public class PatternManagerLayout2 : PatternManager {

	void Start () {
		float w = _grass.GetComponent<SpriteRenderer>().sprite.rect.width;
		//Debug.Log (w);
		period = (Mathf.Sqrt(w)-0.5f) / (GlobalVariables.layout2Speed);
		curTime	= period;
		generateTime = period;
		generateGrass(_generateInitPos);
	}
}
