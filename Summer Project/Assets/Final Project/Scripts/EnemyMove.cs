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
	}
}
