using UnityEngine;
using System.Collections;

public class TurnPlayer : MonoBehaviour {


	private Vector3 scale = new Vector3 (0.4f, 0.4f, 0.4f);

	void ChangeFace (float _x){
		
		scale.x = _x;
		transform.localScale = scale;
	}

	void Update () {
		if (Input.GetKey (KeyCode.UpArrow))
			ChangeFace (0.4f);
		if (Input.GetKey (KeyCode.DownArrow))
			ChangeFace (-0.4f);
			
	}
}
