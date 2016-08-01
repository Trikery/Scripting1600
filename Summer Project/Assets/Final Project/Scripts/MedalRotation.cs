using UnityEngine;
using System.Collections;

public class MedalRotation : MonoBehaviour {

	public float rotateSpeed = 5f;

	void Rotate () 
	{
		transform.Rotate (rotateSpeed, 0, rotateSpeed);
	}
	void Update () {
		Rotate ();
	}
}
