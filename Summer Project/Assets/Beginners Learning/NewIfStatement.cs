using UnityEngine;
using System.Collections;

public class NewIfStatement : MonoBehaviour {

	public bool myBool = false;
	public int hit = 1; 
	public string myString;
	const string cheat = "BOOM1";
	const string cheat1 = "BOOM2";

	void Update () {
		if (myString == cheat)
			print ("KaBOOOOM!!!");
		else if (myString == cheat1)
			print ("sploooooosh....");
		else
			print (false);
		}
	}
	

