using UnityEngine;
using System.Collections;

public class ExampleScript_B : MonoBehaviour {

	public int weapon = 0;
	public string weaponName;
			
	void Update()
	{
		if (Input.GetKeyUp ("space")) 
		{
			WeaponSearch ();
			DisplayMessage ();
		}

	}


	void WeaponSearch () {

	weapon = Random.Range (1, 20);

	switch (weapon) {
	case 1:
			weaponName = "Sword";
		break;
	case 2:
			weaponName = "Battle Axe";
		break;
	case 3:
			weaponName = "Staff";
			break;
	case 4:
			weaponName = "Magic Bow";
		break;
	default : 
		print ("The Chest was Empty");
		break;
	
	}


}
	void DisplayMessage ()
	{
		if (weapon < 5) 
		{
			print ("You Found The " + weaponName + "!");
		}

	}

}
		
