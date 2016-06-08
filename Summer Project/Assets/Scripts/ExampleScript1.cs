using UnityEngine;
using System.Collections;

public class ExampleScript1 : MonoBehaviour {
	//this is a comment
	/* 
	Assignment Operators:
	=  used as a basic assignment to assign a value to a variable
	+=  lets us use shorthand x = x + y means (x+=y)
	-=  ""                 "" x = x - y means (x-=y)
	also *=  and  /=  for multiplication and division
	%=

	Arithmatic Operators
	+ addition
	- subtraction
	* multiplication
	/ division
	% modulus  (produces the remainder of an equation)
	++  means +1
	--  means -1

	Comparison Operators
	== 	(is equal to) 
	!= 	(not equal to)
	>	(greater than)
	<	(less than)
	>=	(greater than or equal to)
	<=	(less than or equal to)

Logical Operators
&&	And (if x and y are equalto z, do this)
||	Or	(if x or y are equalto z, do this)
!	Not	(if x is not equalto z, do this)	
	
	*/
	public float speed = 0.0f;
	public float distance = 0.0f;
	public float time = 0.0f;

	public float maxSpeedLimit;
	public float minSpeedLimit;

	// Use this for initialization
	void Start () {
		speed = distance / time;
		print ("You are traveling at " + speed + " mph.");
		if (speed > maxSpeedLimit) {
			print ("You are exeding " + maxSpeedLimit + ".");
		} else if (speed < minSpeedLimit) {
			print ("You are Going too Slow.");
		
		} else if (speed == maxSpeedLimit || speed == minSpeedLimit) {
			print ("You are Close to Breaking the Law!");
		} else
		{
			print ("You are within the speed limit");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
