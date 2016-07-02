using UnityEngine;
using System.Collections;

public class BattleSequence : MonoBehaviour {
	public BattleOperation turns;
	public ObjectValue lifeStart;

	int whatTreasure;

	void Start (){
		print ("You Have Three Heroes to Choose From.");
		string[]heroes = new string[3];
		heroes[0] = "Cotton has 70 Attack and 60 HP";
		heroes[1] = "Silk has 40 Attack and 80 HP";
		heroes[2] = "Denim has 80 Attack and 40 HP";
		foreach (string hero in heroes) {
			print (hero);
		}
		print ("You Get One of Two Power Ups.");
		string[]items = new string[2];
		items [0] = "Firey Fruit gives a +20 Attack Bonus";
		items [1] = "Frosty Fruit gives a +20 HP Bonus";
		foreach (string item in items) {
			print (item);
			print ("You must pick a monster to face off against");
			print ("click the pill to begin");
		}
	}


	void OnMouseDown(){
		int heroLife = lifeStart.HeroHP ();
		int enemyLife = lifeStart.EnemyHP ();

		print ("The Hero's HP is " + heroLife);											//first prints the HP's of the Enemies
		print ("The Enemy's HP is " + enemyLife);
		heroLife = turns.HeroAttacks ();

		print ("The Hero deals " + turns.EnemyRemainingLife() + " damage to the Enemy.  The Enemy has " + turns.HeroAttacks() + " HP left.");

		if (turns.HeroAttacks() > 0) 
		{ 
			enemyLife = turns.EnemyAttacks ();
			print ("The Enemy Dealt " + turns.HeroRemainingLife() + " Damage to the Hero!  The Hero has " + turns.EnemyAttacks() + " HP left." );
			if (turns.EnemyAttacks() > 0) {
				print ("The Hero Survived with " + turns.EnemyAttacks () + " HP Left Over.");
				print ("You Win!");
			} else {
				print ("The Enemy has Killed the Hero.");
				print ("You Lose!");
			}
		}
			
		else 
		{
			print ("The Hero has defeated the Enemy!");
			print ("You Win!");
			print ("Press Space to Get Your Treasure!");
		}
	}



	public void GetTreasure (){
		for (int i = 0; i < 1; i++) {
			whatTreasure = Random.Range (1, 10);
			if (whatTreasure < 2) 
				print ("The Chest was Empty");
			if (whatTreasure >= 2 && whatTreasure < 4)
				print ("You Found the Pig Wings!");
			if (whatTreasure >= 4 && whatTreasure < 6)
				print ("You Found SabuellaSteve!");
			if (whatTreasure >= 6 && whatTreasure < 8)
				print ("You Found an AdrenoFruit!");
			if (whatTreasure >= 8)
				print ("You Found the Dragon's Eye!");
			else {
			}


		}

	}

	void Update (){
		if (Input.GetKeyUp ("space")) {
			GetTreasure ();

		} else {
		}
	
	}
}



	/*
		if (Input.GetKeyUp("key")){}    Usually done in Udate or something
	*/

