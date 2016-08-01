using UnityEngine;
using System.Collections;

public class MovementTest : MonoBehaviour {

	public void Move () {
		if (Input.GetKey (KeyCode.UpArrow) && this.transform.position.z < 8) {
			transform.Translate (0, 0, 0.5f);
		}
		if (Input.GetKey (KeyCode.DownArrow) && this.transform.position.z > -8) {
			transform.Translate (0, 0, -0.5f);
		}
		if (Input.GetKey (KeyCode.RightArrow) && this.transform.position.x < 8) {
			transform.Translate (.5f, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow) && this.transform.position.x > -8) {
			transform.Translate (-.5f, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space) && this.transform.position.y < 0f) {
			transform.Translate ( 0, 400 * Time.deltaTime, 0);
		}
	
	}
}
