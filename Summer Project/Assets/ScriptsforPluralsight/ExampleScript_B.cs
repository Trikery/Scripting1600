using UnityEngine;
using System.Collections;

public class ExampleScript_B : MonoBehaviour {

	public int weapon = 0;
	public string weaponName;

	public int enemyDistance;
			
	void Update()
	{
		if (Input.GetKeyUp ("space")) 
		{
			WeaponSearch ();
			DisplayMessage ();
			EnemySearch ();
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
	void EnemySearch (){
		for (int i = 0; i < 5; i++) {
			enemyDistance = Random.Range (1, 10);
			if (enemyDistance >= 8) 
			{
				print ("The Enemy is still far away");
			}
			if(enemyDistance >= 4 && enemyDistance <= 7)
				{
					print ("The Enemy is getting close");	
				}
			if (enemyDistance < 4) 
			{
				print ("The Enemy is Right on Top of YOU!!!");
			}
		}

	
	}
}
		
