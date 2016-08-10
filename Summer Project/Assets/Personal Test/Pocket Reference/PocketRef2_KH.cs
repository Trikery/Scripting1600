using UnityEngine;
using System.Collections;

public class PocketRef2_KH : MonoBehaviour {

	public int myInt;
	public string operation;

	void Main (){
		if (operation == "multipy")
			print (FeetToInches (myInt));
		else
			print ("You're so Stupid!");
	
	}
	int FeetToInches (int feet){
		int inches = feet * 12;
		return inches;
	}
}
