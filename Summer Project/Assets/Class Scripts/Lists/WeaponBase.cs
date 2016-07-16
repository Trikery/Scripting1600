using UnityEngine;
using System.Collections;
using StudioThorn;

namespace StudioThorn{

	public class WeaponBase : MonoBehaviour {

		public WeaponInventory myWeaponsInventory;
		//Weapon Name is the GameObject Name
		public int firePower;
		public int ammoCount;

		void OnMouseUp(){
			if (myWeaponsInventory.myWeapons.Count < 2) {
			myWeaponsInventory.myWeapons.Add (this);
			gameObject.SetActive (false);
			}
		}
	}
}
