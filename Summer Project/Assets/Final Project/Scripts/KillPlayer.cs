using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	//The Easy Way?
	void OnTriggerEnter(){
		print ("You've Been Caught!!!  YOU ARE DEAD!!!");
		transform.parent.gameObject.SetActive (false);
	}
}
