using UnityEngine;
using System.Collections;

public class Loops_While : MonoBehaviour {

	public float i = 0;

	void OnMouseDown (){
		while (i < 5) {
			print (i++);
		}



	}
}