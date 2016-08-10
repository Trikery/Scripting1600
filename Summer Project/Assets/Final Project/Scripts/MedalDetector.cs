using UnityEngine;
using System.Collections;

public class MedalDetector : MonoBehaviour {

	void Update () {
		if (EnemySpeedChange.enemiesKilled == 4){
			this.gameObject.SetActive (false);


		}
	}
}
