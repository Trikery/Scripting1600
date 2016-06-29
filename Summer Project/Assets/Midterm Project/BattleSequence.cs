using UnityEngine;
using System.Collections;

public class BattleSequence : MonoBehaviour {
	public BattleOperation turns;
	public ObjectValue lifeStart;


	void OnMouseDown(){

		int enemylife = turns.HeroAttacks ();												//makes functions variables
		int herolife = turns.EnemyAttacks ();

		print ("The Hero's HP is " + herolife);												//first prints the HP's of the Enemies
		print ("The Enemy's HP is " + enemylife);
		turns.HeroAttacks ();

		print ("The Hero deals Damage to Enemy.  The Enemy has " + enemylife + " HP");

		if (enemylife >= 0) { 																//loop begins until the enemy is defeated
			turns.EnemyAttacks();
																		//if statement that determines that the hero won.  the break is used to end the loop.  I hope.
		} else 
		{
			print ("The Hero has defeated the Enemy!  Congratuations!  You Win");
		}


			
	} 

}

	/*
		if (Input.GetKeyUp("key")){}    Usually done in Udate or something
	*/

