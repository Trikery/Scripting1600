using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject myLevel;

	void ChangeGame (){
		switch (MyEnums.gameState) {
		case MyEnums.gameStates.Starting:
			print ("Starting Your Game");
			myLevel.SetActive (false);
			break;

		case MyEnums.gameStates.Playing:
			print ("Playing Your Game");
			myLevel.SetActive (true);
			this.gameObject.SetActive (false);
			break;

		case MyEnums.gameStates.Ending:
			print ("Ending Your Game");
			break;

		}
	}

	void Start() {
		ChangeGame ();
	}

	void OnMouseDown (){
		MyEnums.gameState = MyEnums.gameStates.Playing;
		ChangeGame ();
	}

	/*void Update (){
		if (Input.GetKeyUp (KeyCode.X)) {
			MyEnums.gameState = MyEnums.gameStates.Ending;
			ChangeGame ();
		}
	}*/

}
