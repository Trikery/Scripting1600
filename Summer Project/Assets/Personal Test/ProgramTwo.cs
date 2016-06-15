using UnityEngine;
using System.Collections;

public class ProgramTwo : MonoBehaviour {
	/*
	 * Design a Program like this:
	 * Function: Choose two numbers and an Operator in Unity.  The Program uses an if statement to determine
	 * the solution and then prints it.
	 */

	public enum MyOperations { ADD, SUBTRACT, MULTIPLY, DIVIDE, SQUARED };

	public MyOperations currentOperation;

	public float num_one;
	public float num_two;

	float ChangeOperation (float _one, float _two){
		float value = 0;
		switch (currentOperation) {
		case MyOperations.ADD: 
			value = _one + _two;
			break;
		case MyOperations.SUBTRACT: 
			value = _one - _two;
			break;
		case MyOperations.MULTIPLY: 
			value = _one * _two;
			break;
		case MyOperations.DIVIDE: 
			value = _one / _two;
			break;
		case MyOperations.SQUARED: 
			value = (_one + _two) * (_one + _two);
			break;
		}

		return value;
	}

	void OnMouseDown (){
		float finalValue = ChangeOperation (num_one, num_two);
		print (finalValue);
	}
}
	/*
	 * void Start (){
		if (operation == "plus" | operation == "+" | operation == "add")  //user chooses one of the following words in each if else statement
			print (PlusNumbers (num_one, num_two));// each will print the result of the various funtions listed below
		
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
	*/

	/* All the functions to Add, Subtract, Multiply, Divide, and Square numbers one and two.
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
	}*/
		
