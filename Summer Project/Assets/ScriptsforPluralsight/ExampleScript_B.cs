using UnityEngine;
using System.Collections;

public class ExampleScript_B : MonoBehaviour {

	public int weapon = 0;

	void Start(){
		weapon = Random.Range (1, 5);

		print ("You Open A Chest");

		switch (weapon) {
		case 1:
			print ("You Found the Sword!");
			break;
		case 2:
			print ("You've found a Battle Axe!");
			break;
		case 3:
			print ("You Found a Staff!");
			break;
		case 4:
			print ("You Found the Magic Bow!");
			break;
		default : 
			print ("The Chest was Empty");
			break;

		}
	}

}
