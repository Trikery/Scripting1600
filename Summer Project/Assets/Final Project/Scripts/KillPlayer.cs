using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	void Kill (){
		print ("You've Been Caught!!!  YOU ARE DEAD!!!");
		transform.parent.gameObject.SetActive (false);

	}

	//The Easy Way?
	void OnTriggerEnter(){
		switch (PlayerStates.currentPlayerState) {
		case PlayerStates.playerStates.flight: 
			Kill ();
			break;
		case PlayerStates.playerStates.fight:
			break;
		}
	}
}
