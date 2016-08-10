using UnityEngine;
using System.Collections;

public class ProgramThree : MonoBehaviour {

	public string[] toDos;

	void OnMouseDown ()
	{
		foreach (string list in toDos) {
			print ("Do " + list);
		
		}
	
	}
}
