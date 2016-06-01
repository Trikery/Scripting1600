using UnityEngine;
using System.Collections;
// a convention is how you write the file name i.e. Project_Portion_User.cs etc.
public class TestMay31 : MonoBehaviour {
	float feets = 30.5f;
	string inch = "In Inches: ";
	string yard = "In Yards: ";
	string miles = "In Miles: ";
	string notMile = "Value is less than one mile.";
	void Main() {
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
		float mile = feet / 5280;
		return mile;	
		/*if (mile < 1) {
			print (notMile);
		} else
			print (miles + mile);
			*/
	}
}
