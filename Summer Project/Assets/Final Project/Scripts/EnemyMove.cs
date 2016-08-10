using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public NavMeshAgent agent;
	public Transform player;

	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	

	void Update () {
		agent.destination = player.position;
		agent.speed = 1.5f + EnemySpeedChange.gotAPowerUp;
	}
}


/*
 * 4 1.5
 * 3 3
 * 2 4.5
 * 1 6
 */