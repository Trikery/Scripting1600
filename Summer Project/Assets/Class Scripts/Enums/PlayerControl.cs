using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float healthTimer = 0;
	public float maxTime = 30;

	void Update () {
		switch (MyEnums.gameState){
		case MyEnums.gameStates.Attacked:
			if (healthTimer < 30) {
				print (healthTimer);
				healthTimer = Time.time;
			} else {
				MyEnums.gameState = MyEnums.gameStates.Dying;
				this.gameObject.SetActive (false);
			}
			break;

		}
	}
}
