using UnityEngine;
using System.Collections;

public class BattleSequence : MonoBehaviour {
	public BattleOperation turns;

	/*
		if (Input.GetKeyUp("key")){}    Usually done in Udate or something
	*/
	// this just a function that one of my pluralsight videos used.  To make the program execute with a specific key.  Thought it'd be useful sometime.

	void OnMouseDown () 
	{
		int enemylife = turns.HeroAttacks ();												//makes functions variables
		int herolife = turns.EnemyAttacks ();

		print ("The Hero's HP is " + herolife);												//first prints the HP's of the Enemies
		print ("The Enemy's HP is " + enemylife);


		while (enemylife >= 0) 																//loop begins until the enemy is defeated
		{
			print ("The Hero prepares to attack.  Hero has " + herolife + " HP");
			print ("The Hero Attacked!  Leaving the Enemy with " + enemylife + " HP.");
			turns.HeroAttacks ();
			if (enemylife <= 0) 															//if statement that determines that the hero won.  the break is used to end the loop.  I hope.
			{
				print (" has defeated the Enemy!  Congratuations!  You Win");
				break;																		//  !!!???!!!
			}
			else 
			{
				print ("The Enemy Survived and is retaliating!");
				turns.EnemyAttacks ();

			}
		} 
			print ("The Enemy has defeated you!  You are no more...");

	}


}
