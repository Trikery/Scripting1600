using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour {

	public List<PowerUpGet> PowerPills = new List<PowerUpGet> ();

	public static int i = 0;

	public void AddPowerPill (PowerUpGet _pill)
	{
		PowerPills.Add (_pill);
		i++;
		print ("You got a Power Pill!  Now you can Kill an Enemy!");
	}

	void Update (){
		if (i > 0) {
			PlayerStates.currentPlayerState = PlayerStates.playerStates.fight;
		} else {
			PlayerStates.currentPlayerState = PlayerStates.playerStates.flight;
		}
			
	
	}

}
