using UnityEngine;
using System.Collections;

public class PowerUpGet : MonoBehaviour {

	public PlayerInventory addAPowerUp;

	//this function will add a power up the players inventory 
	void OnTriggerEnter (){
		addAPowerUp.AddPowerPill (this);
		EnemySpeedChange.gotAPowerUp = EnemySpeedChange.gotAPowerUp + 1.5f;
		gameObject.SetActive (false);
	
	}
}
