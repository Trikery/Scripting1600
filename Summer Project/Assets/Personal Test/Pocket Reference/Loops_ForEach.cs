using UnityEngine;
using System.Collections;

public class Loops_ForEach : MonoBehaviour {



		
	void OnMouseDown () {
		string[] chara = new string[3];
		chara[0] = "Cotton";
		chara[1] = "Silk";
		chara[2] = "Denim";

		foreach (string c in chara) {
			print (c);
		
		}
	
	}

}
