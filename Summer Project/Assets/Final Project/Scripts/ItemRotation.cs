using UnityEngine;
using System.Collections;

public class ItemRotation : MonoBehaviour {

	//basic script that makes the item rotate on the x and y axis.

	public float rotateSpeed = 5f;

	void Rotate () 
	{
		transform.Rotate (rotateSpeed, rotateSpeed, 0);
	}
	void Update () {
		Rotate ();
	}
}
