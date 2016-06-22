using UnityEngine;
using System.Collections;

[System.Serializable]
public class Base_Ammo {

	//This controls the amount of ammo and the power level of the ammo.
	public int ammoCount;
	public int ammoPower;


	//Call Weapon Function
	public void Fire (){
		if (ammoCount > 0) {
			ammoCount--;
			Debug.Log (ammoCount);
		} else {
			Debug.Log ("Out of Ammo");
		}
			
	}
}
