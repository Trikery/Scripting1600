using UnityEngine;
using System.Collections;

public class MedalRotation : MonoBehaviour {

	public GameObject WinScreen;
	public float rotateSpeed = 5f;  //variable value for speed rotation

	void Update () {
		transform.Rotate (rotateSpeed, 0, rotateSpeed);  // this will make the medal endlessly rotate, making it more visable and identify it as an item.
	}
	void OnTriggerEnter (){    //change the screen to menu screen.
		gameObject.SetActive (false);
		WinScreen.SetActive (true);
	
	}
}
