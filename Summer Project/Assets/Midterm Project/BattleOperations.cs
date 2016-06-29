[System.Serializable]

public class BattleOperation{
	public ObjectValue values;
	public CottonFight choices;

	public int HeroAttacks () {						//A Function that determines the outcome of the Hero's Turn
		int result;
		int enemyLife = values.EnemyHP ();
		int heroAttack = values.HeroPower ();
		result = enemyLife - heroAttack;
		return result;
	}

	public int EnemyAttacks () {					//A function that determines the outcome of the Enemy's Turn
		int result;
		int heroLife = values.HeroHP ();
		int enemyAttack = values.EnemyPower ();
		result = heroLife - enemyAttack;
		return result;
	}




}