using UnityEngine;
using System.Collections;

public class StartLoad : MonoBehaviour {

	public GameObject loader;  //references loading canvas
	public GameObject menu;	   //references menu canvas

	void Start (){
		loader.SetActive (false);  //sets the loading canvas off at the beginning of the menu
	}
	public void BeginLoader (){
		loader.SetActive (true);   //sets the loading canvas active upon clicking the button
		GameState.currentGameState = GameState.States.Loading;  //sets the gamestate to Loading
		menu.SetActive (false);		//turns off the menu and moves to the next GameState
	}

}
