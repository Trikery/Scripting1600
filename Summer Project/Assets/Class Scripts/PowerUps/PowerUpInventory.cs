using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUpInventory : MonoBehaviour {


	public List<PowerUpBase> myPowerUps = new List<PowerUpBase> ();

	private int i = -1;

	public void AddPowerUpToList (PowerUpBase _pub)
	{
		myPowerUps.Add (_pub);
		i++;
		print (_pub.name);
	}



	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.A)) //activates if the Key A is pushed
		{
			if (i > -1 && i < 10) {
				PowerUpStatics.mySpeed += myPowerUps [i].speed;  //???
				myPowerUps.RemoveAt (i);  //???
				i--;  //???
				print (PowerUpStatics.mySpeed);  
			} else
				print ("You Have No Power Ups!");
		}
	}
}
