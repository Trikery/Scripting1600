using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public GameObject retryButton;
	int waitTime = 2;

	IEnumerator RetryButtonAppear (){
		while (waitTime > 0) {
			yield return new WaitForSeconds (1);
			waitTime--;
		}
		GameState.currentGameState = GameState.States.GameOver;
			retryButton.SetActive (true);
	}
	void Start () {
		StartCoroutine (RetryButtonAppear ());

	}
}
