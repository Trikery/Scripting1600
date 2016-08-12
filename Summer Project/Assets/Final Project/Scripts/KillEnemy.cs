using UnityEngine;
using System.Collections;

public class KillEnemy : MonoBehaviour {

	public PlayerInventory PillSubtraction;

	// if the player state is set to fight than this script activates and the player can kill enemies

	void OnTriggerEnter () {
		switch (PlayerStates.currentPlayerState) {
		case PlayerStates.playerStates.fight:
			transform.gameObject.SetActive (false);
			PlayerInventory.i--;  
			EnemySpeedChange.enemiesKilled++;  //adds 1 int to the enemies killed variable
			PillSubtraction.PowerPills.RemoveAt (PlayerInventory.i); // this will remove one item from the inventory
			break;
		}
	}
}
