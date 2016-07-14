using UnityEngine;
using System.Collections;

public class ProgramSix : MonoBehaviour
{

	//Program Six
	// Create a Program that uses a for loop to calculate the increase of bytes in memory capacity.

	public int times;  //input number of times to run
	int number = 16; //input number


	void OnMouseDown() //click to calculate
	{
		for (int i = 0; i < times; i++) { //determine number of times to run the loop
			number = number * 2;// multiply the number by two
			print (number); //print the new number.  Numbers are divisable by 16 and are multiplied each time.
		}
	}
}
