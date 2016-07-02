using UnityEngine;
using System.Collections;

public class Loops_DoWhile : MonoBehaviour {

	public float i = 1;
	void OnMouseDown () {
		do {
			print (i++);
		} while (i <= 10);
	}

}
