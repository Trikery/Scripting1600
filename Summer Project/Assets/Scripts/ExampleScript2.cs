using UnityEngine;
using System.Collections;

public class ExampleScript2 : MonoBehaviour {

	public float xValue = 0.0f;
	public float yValue = 0.0f;

	void SolveXY (){
		float divideValue = (xValue / yValue);

		if (xValue == 0){
			print ("You cannot divide a number by Zero");
			print ("Imagine you have " + yValue + " cookies and you try to divide them among zero friends.  You see, it doesn't make sense.  The cookie monster is sad because he has no cookies, and you are sad because you have no friends.");
		}
		else
			print (xValue + " devided by " + yValue + " equals " + divideValue);

	
	}
	void Start (){
		SolveXY ();

	
	}
}
