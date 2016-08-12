using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public GameObject retryButton;
	int waitTime = 2;  //establish amount of time to wait before showing the button

	IEnumerator RetryButtonAppear (){
		while (waitTime > 0) {
			yield return new WaitForSeconds (1);
			waitTime--;
		}
		GameState.currentGameState = GameState.States.GameOver;
			retryButton.SetActive (true);
	}
	void Start () {			//activate coroutine
		StartCoroutine (RetryButtonAppear ());

	}
}
