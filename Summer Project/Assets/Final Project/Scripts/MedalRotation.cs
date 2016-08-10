using UnityEngine;
using System.Collections;

public class MedalRotation : MonoBehaviour {

	public float rotateSpeed = 5f;

	void Update () {
		transform.Rotate (rotateSpeed, 0, rotateSpeed);
	}
	void OnTriggerEnter (){
		gameObject.SetActive (false);
	
	}
}
