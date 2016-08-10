using UnityEngine;
using System.Collections;

public class PowerUpGet : MonoBehaviour {

	public PlayerInventory addAPowerUp;

	void OnTriggerEnter (){
		addAPowerUp.AddPowerPill (this);
		EnemySpeedChange.gotAPowerUp = EnemySpeedChange.gotAPowerUp + 1.5f;
		gameObject.SetActive (false);
	
	}
}
