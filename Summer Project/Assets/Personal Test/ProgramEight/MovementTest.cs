using UnityEngine;
using System.Collections;

public class MovementTest : MonoBehaviour {

	public void Move () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0, 0.5f);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, 0, -0.5f);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (.5f, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-.5f, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			transform.Translate ( 0, 400 * Time.deltaTime, 0);
		}
	
	}

}
