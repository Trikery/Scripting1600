using UnityEngine;
using System.Collections;

public class TestFunctions_KH : MonoBehaviour {
	/*
Test 1
	void MyFloSolve (float int1, float int2){
		float FinalSolution = int1 + int2;
		print (FinalSolution);
	}
	void Start (){
		MyFloSolve (10, 5);
	}
	*/
	//public makes it visible in unity

	/*
	public string username1;
	void PrintUsername (){
		print (username + " You Win!");
	}
	//You always need to call a function in order for it to do anything
	void Start (){
		PrintUsername ();
	}
	*/
	public string username2;
	public string username1;
	string win = " Wins!";
	public bool winner;

	void RightName () {
		if (winner) {
			print (username1 + win);
		}
		else{
			print (username2 + win);
		}
		

	}
	void Start (){
		RightName ();
	
	}


}
