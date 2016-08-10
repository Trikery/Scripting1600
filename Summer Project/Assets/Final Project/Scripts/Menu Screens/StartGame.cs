using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public GameObject button;

	public GameObject level;

	void Start (){
		level.SetActive (false);
	}

	public void StartThisGame (){
		level.SetActive (true);
		GameState.currentGameState = GameState.States.Playing;
		this.gameObject.SetActive (false);
	}
}
