using UnityEngine;
using System.Collections;

public class GameEightController : MonoBehaviour {

	public MovementTest PlayerMove;
	public EnemyMovement EneMove;

	void FixedUpdate () {
		PlayerMove.Move ();
		StartCoroutine (EneMove.Mob ());
	}
}
