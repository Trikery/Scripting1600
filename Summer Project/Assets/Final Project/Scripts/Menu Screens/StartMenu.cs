using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	int fadeCount = 3;
	public GameObject playButton;

	IEnumerator StartUpMenu (){
		while (fadeCount > 0) {
			yield return new WaitForSeconds (1);
			fadeCount--;
		}
			
		GameState.currentGameState = GameState.States.MenuScreen;
		playButton.SetActive (true);

	}

	void Start (){
		playButton.SetActive (false);
		StartCoroutine (StartUpMenu ());
	}
}
