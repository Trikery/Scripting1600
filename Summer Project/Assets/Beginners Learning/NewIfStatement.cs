using UnityEngine;
using System.Collections;

public class NewIfStatement : MonoBehaviour {

	public bool myBool = false;
	public int hit = 1;

	void Start () {
		if (hit > 1 && hit < 10)
			print (hit);
		else
			print (false);
		}
	}
	

