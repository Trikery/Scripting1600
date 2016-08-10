using UnityEngine;
using System.Collections;

public class KillEnemy : MonoBehaviour {

	public PlayerInventory PillSubtraction;

	void OnTriggerEnter () {
		switch (PlayerStates.currentPlayerState) {
		case PlayerStates.playerStates.fight:
			transform.gameObject.SetActive (false);
			PlayerInventory.i--;
			EnemySpeedChange.enemiesKilled++;
			PillSubtraction.PowerPills.RemoveAt (PlayerInventory.i);
			break;
		}
	}
}
