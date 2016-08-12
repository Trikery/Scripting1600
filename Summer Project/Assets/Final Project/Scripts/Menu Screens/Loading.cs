using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loading : MonoBehaviour {

	public GameObject startButton;
	private Text screenText;

	private int countDown = 5;  //set variable of the loading screen to wait five seconds

	IEnumerator LoadGame (){
		while (countDown > 0) {
			screenText.text = "Loading..." + countDown;  //prints on the screen the countdown text
			yield return new WaitForSeconds (1);  //wait five seconds
			countDown--;
		}

		screenText.text = "Ready to Play!";   //changes the text to "Ready to Play" from Loading
		yield return new WaitForSeconds (1);  
		GameState.currentGameState = GameState.States.Starting;
		startButton.SetActive (true);  //button appears
		gameObject.SetActive (false);  //loading words disappear
	}

	void Start (){
		startButton.SetActive (false); //begin with button inactive
		screenText = GetComponent<Text> (); //access text component
		StartCoroutine (LoadGame ());	//begin LoadGame Coroutine
	}
	
}

