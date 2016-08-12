using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public GameObject button;

	public GameObject level;

	void Start (){		//set the level inactive so that the entities don't kill the player prematurely
		level.SetActive (false);
	}

	public void StartThisGame (){  //button activates the gameplay
		level.SetActive (true);
		GameState.currentGameState = GameState.States.Playing;
		this.gameObject.SetActive (false);
	}
}
