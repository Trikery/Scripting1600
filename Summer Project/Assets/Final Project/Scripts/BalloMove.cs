using UnityEngine;
using System.Collections;

public class BalloMove : MonoBehaviour {

	private CharacterController character;
	private Vector3 moveVector;   	//reference directional control
	public float moveSpeed = 3;		//use this to control the speed of the player  (further update: Speed Up Power UP?)

	void Start () {
		character = GetComponent<CharacterController> ();	//Get Access CharacterController
	}

	void MoveHorizontal (float _myInput) // move based on horizontal directions left/right
	{
		moveVector.x = _myInput;
		moveVector = transform.TransformDirection (moveVector*moveSpeed*Time.deltaTime);
		character.Move (moveVector);
	}

	void MoveVertical (float _myInput) 	 // move based on vertical directions up/down
	{
		moveVector.z = _myInput;
		moveVector = transform.TransformDirection (moveVector*moveSpeed*Time.deltaTime);
		character.Move (moveVector);
	}

	void Update () {					// movement activates every frame based on inpu
		MoveVertical (Input.GetAxis ("Vertical"));
		MoveHorizontal (Input.GetAxis ("Horizontal"));
		 
	}
}
