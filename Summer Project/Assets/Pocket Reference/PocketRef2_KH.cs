using UnityEngine;
using System.Collections;

public class PocketRef2_KH : MonoBehaviour {

	void Main (){
		print (FeetToInches(20));
		print (FeetToInches(50));
	
	}
	int FeetToInches (int feet){
		int inches = feet * 12;
		return inches;
	}
}
