using UnityEngine;
using System.Collections;

public class Multiplayer : MonoBehaviour {

	public HealthData[] players;//  [] makes HealthData an Array.  It allows us to choose how many elements to include

	void Start (){
		foreach (HealthData _hd in players) {  // need to understand foreach loops better and "in"s
			print (_hd.username + " " + _hd.strength);
			int playerDefence = _hd.TakeDownDefence ();
			print (playerDefence);
	
		}
	}
}	// look up Differences of; References, Instances, Copies, Duplicates, and Embedded.   in C# Pocket Guide
