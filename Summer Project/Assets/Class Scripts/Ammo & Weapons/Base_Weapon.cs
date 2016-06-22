using UnityEngine;
using System.Collections;

public class Base_Weapon : MonoBehaviour {

	public Base_Ammo thisAmmo;

	void Update (){
		thisAmmo.Fire ();
	}
}
