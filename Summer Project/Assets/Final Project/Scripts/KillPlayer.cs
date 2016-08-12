using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	public GameObject gameoverScreen;

	void Kill (){  // the kill funtion
		print ("You've Been Caught!!!  YOU ARE DEAD!!!");
		transform.parent.gameObject.SetActive (false);
		gameoverScreen.SetActive (true);

	}

	//The Easy Way?
	void OnTriggerEnter(){
		switch (PlayerStates.currentPlayerState) {
		case PlayerStates.playerStates.flight:  //if the playerstate is flight the Kill function is activated upon trigger
			Kill ();
			break;
		case PlayerStates.playerStates.fight:
			break;
		}
	}
}
