using UnityEngine;
using System.Collections;
using StudioThorn;

public class PickSilk : MonoBehaviour {

	void OnMouseUp (){
		EnumController.playGame = EnumController.GamePlay.PickSilk;
		this.transform.Translate (.75f, 0, 0);
		print ("SILK!!!");
	}

	void Update (){
		switch (EnumController.playGame) {
		case EnumController.GamePlay.PickCotton:
			this.gameObject.SetActive (false);
			break;
		}

	}
}
