using UnityEngine;
using System.Collections;

public class ProgramOne : MonoBehaviour {
	/*
	 * Design a Program like this:
	 * Function: Choose two numbers and an Operator in Unity.  The Program uses an if statement to determine
	 * the solution and then prints it.
	 */

	public int num_one;
	public int num_two;
	public string operation;
	string fail = "You did not enter a valid Operator";

	void Start (){
		if (operation == "plus" | operation == "+" | operation == "add")
			print (PlusNumbers (num_one, num_two));
		else if (operation == "minus" | operation == "-" | operation == "subtract")
			print (MinusNumbers (num_one, num_two));
		else if (operation == "multiply" | operation == "*" | operation == "x" | operation == "times" | operation == "X")
			print (TimesNumbers (num_one, num_two));
		else if (operation == "divide" | operation == "/" | operation == "fraction" | operation == "over")
			print (DivideNumbers (num_one, num_two));
		else if (operation == "square" | operation == "squared" | operation == "square root")
			print (SquareNumberOne (num_one));
		else 
			print (fail);
	}


	int PlusNumbers (int n1, int n2) {
		int plus;
		plus = n1 + n2;
		return plus;	
	}

	int MinusNumbers (int n1, int n2) {
		int minus;
		minus = n1 - n2;
		return minus;	
	}

	int TimesNumbers (int n1, int n2) {
		int times;
		times = n1 * n2;
		return times;	
	}

	int DivideNumbers (int n1, int n2) {
		int divide;
		divide = n1 * n2;
		return divide;	
	}

	int SquareNumberOne (int n1) {
		int square;
		square = n1 * n1;
		return square;	
	}

}
