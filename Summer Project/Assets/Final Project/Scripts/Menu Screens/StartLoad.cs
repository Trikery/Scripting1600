using UnityEngine;
using System.Collections;

public class StartLoad : MonoBehaviour {

	public GameObject loader;
	public GameObject menu;

	void Start (){
		loader.SetActive (false);
	}
	public void BeginLoader (){
		loader.SetActive (true);
		GameState.currentGameState = GameState.States.Loading;
		menu.SetActive (false);
	}

}
