using UnityEngine;
using System.Collections;

public class HealthDamage : MonoBehaviour {

	public Multiplayer mP;

	// Use this for initialization
	void OnMouseDown () {
		foreach (HealthData _hd in mP.players){  //what does foreach mean
			if(_hd.username == this.name){
				print (_hd.TakeDownDefence () + " " + _hd.username);
			}
		}
	}
}
