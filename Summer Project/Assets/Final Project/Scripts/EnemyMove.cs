using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public NavMeshAgent agent;
	public Transform player;

	void Start () {
		agent = GetComponent<NavMeshAgent>();  //gives the enemy navigation
	}
	

	void Update () {
		agent.destination = player.position;  //the enemy is drawn towards the player
		agent.speed = 1.5f + EnemySpeedChange.gotAPowerUp; //change the speed of the enemy
	}
}


/*  Enemies speed changes based on how many power pills have been collected increasing at a rate of 1.5f per pill
 * when 4 enemies remain {1.5 speed}
 * when 3 enemies remain {3 speed}  enemies now match player speed
 * when 2 enemies remain {4.5 speed}
 * when 1 enemy remains {6 speeds}
 */