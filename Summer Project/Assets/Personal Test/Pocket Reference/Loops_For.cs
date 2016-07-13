using UnityEngine;
using System.Collections;

public class Loops_For : MonoBehaviour {
	// for script exercise in C# Reference Guide
	public float i = 0;

	void OnMouseDown (){
		for (float curfib = 1, prefib = 1; i < 10; i++) { // a comma can be placed in between two initializations, conditions, or iterations.
			print (prefib);  //print 1
			float newfib = prefib + curfib; //new variable "newfib" which equals 1+1 = 2
			prefib = curfib; //change prefib to curfib.  prefib = 1.
			curfib = newfib; //change curfib to newfib.  curfib = 2.  
			//i doesn't actually do anything here.
			//print 1
			//newfib = 3
			//prefib now = 2
			//curfub now = 3
			//print 2
			//newfib = 5
			//prefib = 3
			//curfib = 5
			//loop
		}
	}
}

