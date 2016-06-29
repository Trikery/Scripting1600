using UnityEngine;
using System.Collections;

public class ObjectValue{							
	public CottonFight choice;


	public CottonFight.Characters characterSelect;  //creates a variable to reference the Character Selection, Enemy, and Power Up
	public CottonFight.Enemies enemySelect;
	public CottonFight.PowerUps powerUpSelect;


	/*												//Oh shoot...  These Variables were written to help determine the value of the HP based on which powerup had been taken.
	int HpPowerUp (){
		int value = HeroLife () + 20;					//Without these the Program won't work properly, and Cotton, Silk, and Denim will be slaughtered!
		return value;
	}												//Note:  Add the secondary case scenario's before wednesday.  aka when I get home.
													
													 * switch (powerUpSelect){
													 * case CottonFight.PowerUps.FireyFruit:
													 * value = value + 20;													
													 * ... HeroHP () or HeroPower ()																										 
													 * break;
													 * }
													 * switch (powerUpSelect){
													 * case CottonFight.PowerUps.FrostyFruit:
													 * value = value + 20;													
													 * ... HeroHP () or HeroPower ()																										 
													 * break;
													 * }
													 * 
													 *
													 //insert


	int AttackPowerUp (){
		int value = HeroPower () + 20;
		return value;
	}
	*/


	public int HeroHP (){							//Based on switch of the number this function should determine the value of the heroes HP
		int value = 0;
		switch (characterSelect) {
		case CottonFight.Characters.Cotton:
			value = 80;
			break;
		case CottonFight.Characters.Silk:
			value = 90;
			break;
		case CottonFight.Characters.Denim:
			value = 60;
			break;
		}
		return value;
	}


	public int HeroPower (){						//Based on switch of the number this function should determine the value of the hero's Power
		int value = 0;
	switch (characterSelect) {
		case CottonFight.Characters.Cotton:
			value = 50;
			break;
		case CottonFight.Characters.Silk:
			value = 30;
			break;
		case CottonFight.Characters.Denim:
			value = 60;
			break;
		}
		return value;
	}
	public int EnemyHP (){							//Based on switch of the number this function should determine the value of the enemy's HP
		int value = 0;
		switch (enemySelect) {
		case CottonFight.Enemies.Cthulian:
			value = 80;
			break;
		case CottonFight.Enemies.Carnisaur:
			value = 70;
			break;
		case CottonFight.Enemies.Wolfas:
			value = 60;
			break;
		}
		return value;
	}

	public int EnemyPower (){						//Based on switch of the number this function should determine the value of the enemy's Power
		int value = 0;
		switch (enemySelect) {
		case CottonFight.Enemies.Cthulian:
			value = 80;
			break;
		case CottonFight.Enemies.Carnisaur:
			value = 70;
			break;
		case CottonFight.Enemies.Wolfas:
			value = 90;
			break;
		}
		return value;
	}

}



/*  Battle Results
 * Cotton
 * 	firey fruit < Cthulian 	< frosty fruit
 * 	firey fruit > Carnisaur < frosty fruit		Defeats Carnisaur either way
 * 	firey fruit <  Wolfas 	< frosty fruit
 * 
 * Silk
 * 	firey fruit > Cthulian 	> frosty fruit
 * 	firey fruit > Carnisaur > frosty fruit
 * 	firey fruit <  Wolfas 	< frosty fruit
 * 
 * Denim
 * 	firey fruit > Cthulian 	> frosty fruit
 * 	firey fruit > Carnisaur < frosty fruit		Defeats Carnisaur either way
 * 	firey fruit >  Wolfas 	< frosty fruit		Defeats Wolfas either way */