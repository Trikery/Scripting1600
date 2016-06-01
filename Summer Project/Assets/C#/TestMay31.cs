using UnityEngine;
using System.Collections;

public class TestMay31 : MonoBehaviour {
	 void Main() {
		float feets = 30.5f;
		string inch = "In Inches: ";
		string yard = "In Yards: ";
		string miles = "In Miles:";
		string notMile = "Value is less than one mile.";
		print (inch + FeetToInches (feets));
		print (yard + FeetToYard (feets));
	}
	float FeetToInches (float feet) {
			float inches = feet * 12;
			return inches;
	}
	float FeetToYard (float feet){
		float yards = feet / 3;
		return yards;
	}
	float FeetEqualMile (float feet){
		float miles = feet / 5280;

		if (feets > 2580) {
			print ();
		}
			
			
	}
}
