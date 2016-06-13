using UnityEngine;
using System.Collections;

public class TestingSyntax : MonoBehaviour {
	int one;  //these four variables are defined to be used with the functions
	int two;
	int three;
	int four = 10;
	int five;
	float six = 3.14f;
	//in order to use a float the value must have an f at the end of it
	string answer = "Answer is ";
	int Add (int no1, int no2){	 
		//this is an Integer Function with two parameters, defined as no1 and no2
		int no3 = no1 + no2; 	 
		//this defines no3 as a variable.  It must be within the function with it's parameters to be used.
		return no3; 			 
		//the result of the Add function is no3
	}
	int Minus (int no1, int no2){
		int no4 = no1 - no2;
		int no5 = no2 - no1;
		return no4;
		return no5;
	}

	void Start () {
		one = Add (4, 2);  	
		// the function Add is being called and it's parameters are being defined.  These new parameters are called arguments.
		print (one);		
		// we now print the current value of one
		one = Add (6, 9);	
		// by creating a second one of Whatever this is called, we can change the parameters of Add again.
		print (one);
		one = Add (15, 12);
		print (one);
		two = one + Add (2, 4); 
		// here we define two as the adition of one and no3
		print (two);
		three = one + two;  
		// because two has been defined as one+no3 we can add one to that and get three.
		print (three);
		three = four * three + Add (3, 7);  
		//we can also use the same value that we are defining within it's own ... whatever it's called, after the problem is complete three will be updated with the new value that it was used to create
		print (three);
		print (two + one);  
		// we can also add the variables within the print uh... thing as well.
		// I tried "print (two, one);" but it failed.  not sure why.
		print ("What is (27+33)*10+10?");
		print (answer + three.ToString());
		five = Add (6, 2) + Minus (6, 14);  
		/*this is adding together two functions values.
		 * Apparently int variables can handle negative numbers
		 */
		print (five);
		print (Minus (2, 3));
		print (answer + five + six);
		// I didn't know this but apparently you can add any variables together in Mono without the need of something like .ToString()
		// Becuas I entered to return values in the Minus Function the Print Command is 
	}

}
