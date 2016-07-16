using UnityEngine;
using System.Collections;
using StudioThorn;
using System.Collections.Generic;

namespace StudioThorn{
public class Lists2 : MonoBehaviour {

		public Lists1 Inventory;

		public int quantity = 1;

		void OnMouseUp(){
			if (Inventory.fruits.Count < 2) { // remove fruit from ground
			Inventory.fruits.Add (this);
			gameObject.SetActive (false);
			}
		}
	}
}

