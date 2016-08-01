using UnityEngine;
using System.Collections;

public class ItemRotation : MonoBehaviour {

	public float rotateSpeed = 5f;

	void Rotate () 
	{
		transform.Rotate (rotateSpeed, rotateSpeed, 0);
	}
	void Update () {
		Rotate ();
	}
}
