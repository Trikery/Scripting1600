using UnityEngine;
using System.Collections;

public class LoopsTest : MonoBehaviour {

	public int bottles = 1;
	public int hobos = 10;

	void Start (){
		string[] wordsOfWisdom = new string[4];
		wordsOfWisdom [0] = "Drinking Beer is Bad for you";
		wordsOfWisdom [1] = "Drunk Driving costs Thousands of Lives Each Year";
		wordsOfWisdom [2] = "Beer is a Cheep form of Alcohol";
		wordsOfWisdom [3] = "It also makes your Breath Smell Terrible";


		bool startSong = false;
		do {
			print ("Lets sing the Bottles of Beer Song!"); //the do loop plays this one time (There are simpler ways, I know)
		} while (startSong == true);//Because the startsong variable is false, it will not continue to play.

		while (bottles > 0) {
			print (bottles + " bottles of beer on the wall");  //print song of Bottles
			print (bottles + " bottles of beer");
			print ("We Take One Down");
			print ("We Pass it around");
			bottles--;  //Bottles is subtracted by one
			print (bottles + " bottles of beer on the wall");  //New amount of bottles is included in the chorus
		}

		for (; hobos >= bottles; hobos--){
			print ("Theres not enough Beer!  So a hobo left.  " + hobos + " Hobos Remain.");
		}

		foreach (string item in wordsOfWisdom) {
			print (item);
		}
			
	}


}
