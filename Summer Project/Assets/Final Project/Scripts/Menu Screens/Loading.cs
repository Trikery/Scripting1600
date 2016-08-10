using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loading : MonoBehaviour {

	public GameObject startButton;
	private Text screenText;

	private int countDown = 5;

	IEnumerator LoadGame (){
		while (countDown > 0) {
			screenText.text = "Loading..." + countDown;
			yield return new WaitForSeconds (1);
			countDown--;
		}

		screenText.text = "Ready to Play!";
		yield return new WaitForSeconds (1);
		GameState.currentGameState = GameState.States.Starting;
		startButton.SetActive (true);
		gameObject.SetActive (false);
	}

	void Start (){
		startButton.SetActive (false);
		screenText = GetComponent<Text> ();
		StartCoroutine (LoadGame ());
	}
	
}

