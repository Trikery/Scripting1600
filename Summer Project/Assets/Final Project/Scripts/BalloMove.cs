using UnityEngine;
using System.Collections;

public class BalloMove : MonoBehaviour {

	private CharacterController character;
	private Vector3 moveVector;
	public float moveSpeed = 5;

	void Start () {
		character = GetComponent<CharacterController> ();
	}

	void MoveHorizontal (float _myInput) 
	{
		moveVector.x = _myInput;
		moveVector = transform.TransformDirection (moveVector*moveSpeed*Time.deltaTime);
		character.Move (moveVector);
	}

	void MoveVertical (float _myInput) 
	{
		moveVector.z = _myInput;
		moveVector = transform.TransformDirection (moveVector*moveSpeed*Time.deltaTime);
		character.Move (moveVector);
	}

	void Update () {
		MoveVertical (Input.GetAxis ("Vertical"));
		MoveHorizontal (Input.GetAxis ("Horizontal"));
		 
	}
}
