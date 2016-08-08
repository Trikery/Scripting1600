using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour {

	public List<PowerUpGet> PowerPills = new List<PowerUpGet> ();

	public static int i = -1;
	// in order to kill an enemy Ballo must have a powerup in his inventory
	//
	public void AddPowerPill (PowerUpGet _pill)
	{
		PowerPills.Add (_pill);
		i++;
		print ("You got a Power Pill!  Now you can Kill an Enemy!");
	}

	void Update (){
		if (i >= 1 && i <= 3) {
			PlayerStates.currentPlayerState = PlayerStates.playerStates.fight;
		} else if (i == 4) {
		} else {
			PlayerStates.currentPlayerState = PlayerStates.playerStates.flight;
		}
			
	
	}

}
