using UnityEngine;
using System.Collections;

public class MyLoops : MonoBehaviour {

	public string[] myFamily;
	string familyArray;
		
		// Use this for initialization
	void Start () {
		foreach (string _familyName in myFamily) {
			familyArray += (_familyName + " Loves ");

			print (familyArray);
		}
	}

}
