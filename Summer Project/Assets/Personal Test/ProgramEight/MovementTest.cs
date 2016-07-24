using UnityEngine;
using System.Collections;

public class MovementTest : MonoBehaviour {

	public EnemyMovement EneMove;

	IEnumerator Move () {
		while (Input.GetKey (KeyCode.UpArrow) && this.transform.position.z < 8) {
			this.transform.Translate (0, 0, 0.5f);
			yield return new WaitForSeconds (0.5f);
		}
		while (Input.GetKey (KeyCode.DownArrow) && this.transform.position.z > -8) {
			this.transform.Translate (0, 0, -0.5f);
			yield return new WaitForSeconds (0.5f);
		}
		while (Input.GetKey (KeyCode.RightArrow) && this.transform.position.x < 10) {
			this.transform.Translate (.5f, 0, 0);
			yield return new WaitForSeconds (0.5f);
		}
		while (Input.GetKey (KeyCode.LeftArrow) && this.transform.position.x > -1) {
			this.transform.Translate (-.5f, 0, 0);
			yield return new WaitForSeconds (0.5f);
		}
	}
	void Update () {
		StartCoroutine (Move ());
		StartCoroutine (EneMove.Mob ());
	}
}
