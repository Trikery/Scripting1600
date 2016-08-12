using UnityEngine;
using System.Collections;

public class MedalDetector : MonoBehaviour {

	//When all four enemies are defeated the center block will disappear revealing the medal

	void Update () {
		if (EnemySpeedChange.enemiesKilled == 4){  //(Glitch: Sometimes the HiderBlock Disappears prematurely But I can't figure out why
			this.gameObject.SetActive (false);


		}
	}
}
