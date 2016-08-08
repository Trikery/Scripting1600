using UnityEngine;
using System.Collections;

public class PowerUpGet : MonoBehaviour {

	public PlayerInventory addAPowerUp;


	void OnTriggerEnter (){
		
		addAPowerUp.AddPowerPill (this);
		gameObject.SetActive (false);
	
	}
}
