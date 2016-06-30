using UnityEngine;
using System.Collections;
[System.Serializable]

public class CottonFight{

	public enum Characters { Cotton, Silk, Denim };  		//provides user with a choice of character
	public enum PowerUps { FrostyFruit, FireyFruit}; 		//provides user with a choice of power up
	public enum Enemies { Cthulian, Carnisaur, Wolfas };	//provides user with a choice of enemy


	}



/*             ----> PowerUps ----->
 * CottonFight 						 ObjectValues -----> BattleOperations -----> BattleSequence
			   -------------------->

			   --> Define PowerUp -> 
Define Choices                       Define Stats --> Calculate Turn Results --> Initiate Battle Sequence
Make Decisions -------------------->
*/