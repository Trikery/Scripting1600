using UnityEngine;
using System.Collections;

public class EnemySpeedChange : MonoBehaviour{

	public static float gotAPowerUp = 0f;  //identifies a variable determining how many powerups the player has collected
										   //used to change the speed of the enemies

	public static float enemiesKilled = 0f; //identifies a variable of how many enemies have been killed
											// used to determine when to show the medal
}
