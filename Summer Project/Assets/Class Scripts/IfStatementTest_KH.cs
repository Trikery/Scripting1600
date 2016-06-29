using UnityEngine;
using System.Collections;
// a convention is how you write the file name i.e. Project_Portion_User.cs etc.
public class IfStatementTest_KH : MonoBehaviour {
	float feets = 30.5f;
	string inch = "In Inches: ";
	string yard = "In Yards: ";
	/*string miles = "In Miles: ";
	string notMile = "Value is less than one mile.";*/
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
		//later on we will get the chance to use input
		// Use this code at a later time
		return mile;	
		//it is unfair to myself to expect that I will be able to do half of what Ian can do in only one semester
		//I should rather take my time understanding the information and learning the code.
		//Be lessn critical of myself, for not understanding it like I do Math, Art, Biology, Physics, and any of my other strong suits. 
		/*if (mile < 1) {
			print (notMile);
		} else
			print (miles + mile);
			*/
	}
}
