using UnityEngine;
using System.Collections;
using StudioThorn;

public class PickCotton : MonoBehaviour {

	void OnMouseUp (){
		EnumController.playGame = EnumController.GamePlay.PickCotton;
		this.transform.Translate (-.75f, 0, 0);
		print ("COTTON!!!");
	}

	void Update (){
		switch (EnumController.playGame) {
		case EnumController.GamePlay.PickSilk:
			this.gameObject.SetActive (false);
			break;
		}
	
	}
}
