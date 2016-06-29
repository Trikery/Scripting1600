using UnityEngine;
using System.Collections;

public class BattleSequence : MonoBehaviour {
	public BattleOperation turns;
	public ObjectValue lifeStart;


	void OnMouseDown(){
		int heroLife = lifeStart.HeroHP ();
		int enemyLife = lifeStart.EnemyHP ();


		print ("The Hero's HP is " + heroLife);											//first prints the HP's of the Enemies
		print ("The Enemy's HP is " + enemyLife);
		turns.HeroAttacks ();

		print ("The Hero deals Damage to Enemy.  The Enemy has " + heroAttack + " HP");

		if (heroLife >= 0) { 																//loop begins until the enemy is defeated
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

