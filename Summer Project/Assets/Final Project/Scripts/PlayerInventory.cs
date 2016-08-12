using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour {

	public List<PowerUpGet> PowerPills = new List<PowerUpGet> ();  //sets up inventory

	public static int i = 0;  //inventory starts at zero

	public void AddPowerPill (PowerUpGet _pill)  //function that adds a power up
	{
		PowerPills.Add (_pill);
		i++;
		print ("You got a Power Pill!  Now you can Kill an Enemy!");
	}

	void Update (){  //changes the player killing ability based on how many powerups the player has
		if (i > 0) {
			PlayerStates.currentPlayerState = PlayerStates.playerStates.fight;
		} else {
			PlayerStates.currentPlayerState = PlayerStates.playerStates.flight;
		}
		/* For every power up that the player has, they can kill one enemy. */
			
	
	}

}
