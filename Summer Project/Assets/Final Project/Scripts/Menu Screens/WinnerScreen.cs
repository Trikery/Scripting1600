using UnityEngine;
using System.Collections;

public class WinnerScreen : MonoBehaviour {

	public GameObject replayButton;

	IEnumerator ReplayButtonAppear (){  //cause replay button to wait 2 seconds to appear
			yield return new WaitForSeconds (2);

		GameState.currentGameState = GameState.States.WinnerEnding;
		replayButton.SetActive (true);	// make button appear
	}
	void Start () {
		StartCoroutine (ReplayButtonAppear ());  //activate the above script

	}
}
