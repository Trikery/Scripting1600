using UnityEngine;
using System.Collections;
[System.Serializable]

public class PowerUp{

	public CottonFight.PowerUps powerUpSelect;

	public int PowerUpLife (){
		int life = 0;
		switch (powerUpSelect) {
		case CottonFight.PowerUps.FireyFruit:
			life = 0;
			break;
		case CottonFight.PowerUps.FrostyFruit:
			life = 20;
			break;
		}
		return life;
	}
	public int PowerUpAttack (){
		int power = 0;
		switch (powerUpSelect) {
		case CottonFight.PowerUps.FireyFruit:
			power = 20;
			break;
		case CottonFight.PowerUps.FrostyFruit:
			power = 0;
			break;
			}
		return power;
	}


}
