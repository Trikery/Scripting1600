using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	int fadeCount = 3;  //add a fade to the screen appearing
						//update: I have no idea how to do that ^
	public GameObject playButton;

	IEnumerator StartUpMenu (){  //makes the game wait 1 second before making the play button appear
		while (fadeCount > 0) {
			yield return new WaitForSeconds (1);
			fadeCount--;
		}
			
		GameState.currentGameState = GameState.States.MenuScreen;
		playButton.SetActive (true);

	}

	void Start (){
		playButton.SetActive (false);   //screen starts with playbutton set active (note:  it would be good to
										//make sure that all scripts identify what is and is not active at the begining.
										//... seems tedious though)
		StartCoroutine (StartUpMenu ());
	}
}
