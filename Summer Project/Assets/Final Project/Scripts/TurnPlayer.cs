using UnityEngine;
using System.Collections;

public class TurnPlayer : MonoBehaviour {


	private Vector3 scale = new Vector3 (0.4f, 0.4f, 0.4f);

	void ChangeScale (float _x, float _z){
		scale.x = _x;
		scale.z = _z;
		transform.localScale = scale;
	}

	void Update () {
		if (Input.GetKey (KeyCode.UpArrow))
			ChangeScale (0.4f, 0.4f);
		if (Input.GetKey (KeyCode.DownArrow))
			ChangeScale (-0.4f, -0.4f);
			
	}
}
