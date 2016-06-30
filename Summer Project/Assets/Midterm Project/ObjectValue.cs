using UnityEngine;
using System.Collections;
[System.Serializable]

public class ObjectValue{							
	public CottonFight choice;
	public PowerUp powerUp;


	public CottonFight.Characters characterSelect;  //creates a variable to reference the Character Selection, Enemy, and Power Up
	public CottonFight.Enemies enemySelect;


	public int HeroHP (){							//Based on switch of the number this function should determine the value of the heroes HP
		int value = powerUp.PowerUpLife();
			switch (characterSelect) {
			case CottonFight.Characters.Cotton:
			value = value + 60;
				break;
			case CottonFight.Characters.Silk:
			value = value + 80;
				break;
			case CottonFight.Characters.Denim:
			value = value + 40;
				break;
			}
		return value;
	}


	public int HeroPower (){						//Based on switch of the number this function should determine the value of the hero's Power
		int value = powerUp.PowerUpAttack();
	switch (characterSelect) {
		case CottonFight.Characters.Cotton:
			value = value + 70;
			break;
		case CottonFight.Characters.Silk:
			value = value + 40;
			break;
		case CottonFight.Characters.Denim:
			value = value + 80;
			break;
		}
		return value;
	}
	public int EnemyHP (){							//Based on switch of the number this function should determine the value of the enemy's HP
		int value = 0;
		switch (enemySelect) {
		case CottonFight.Enemies.Cthulian:
			value = 90;
			break;
		case CottonFight.Enemies.Carnisaur:
			value = 100;
			break;
		case CottonFight.Enemies.Wolfas:
			value = 80;
			break;
		}
		return value;
	}

	public int EnemyPower (){						//Based on switch of the number this function should 
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