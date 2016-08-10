using UnityEngine;
//Keywords i.e. using
//Libraries i.e. UnityEngine form unity, system.collections, from microsoft
using System.Collections;
public class Syntax : MonoBehaviour{
//class is a container or like a box that can hold the whole dang project with variables and functions alike
// "Syntax" is refering to the name of the file "Syntax.cs"
	int myInt;
	int kirby;
	//variables define values.  variable names start with a lowercase letter.
	int MyInt (int _i, int _j){
		//functions are things than do things.  Functions Names start with Capitalized Letter.
		return _i + _j;
	}
	//Arguments are like parameters but are defined withing the function later, rather than within the parantheses.
	int MyIntBy2 (int _i, int _j){
		int _k = (_i + _j)*2;
		return _k;
		/* this is a function that ends with a value.  It uses _i and _j.  
		In order to determine what this function is equal to, it must by calledx later by the void Start function.
		This is done by the "Function (value of _i, value of _j);  But it must be equal to an 
*/
	}
	int MyIntNoArgs () {
		return 8 + 9 * 10;
	}
	void Start (){
		myInt = MyIntBy2(45, 35);
		print (myInt);
		myInt = MyIntNoArgs ();
		print (myInt);
		myInt = MyInt (2, 3);
		print (myInt);
		kirby = MyInt (4, 5);
		print (kirby);
		
	}

}
