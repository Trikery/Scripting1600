using UnityEngine;
using System.Collections;

public class ProgramFive{

	/* make a program that requires the choice of 3 fruits.
	 * The Kopaians need enough juice to cover all of them.  
	 * But if theres to much, they will fight over the extra and kill each other.  Too little and they starve.
	 * You need exactly 3 bottles of juice.  Different fruits give different amounts of Juice.
	 * Choose how much of each fruit to use to make the juice.
	 */


	//program defines three public functions that will be used by the secondary program.
	//Each program is within the Scope of ProgramFive


	public double PeachJuice (double _pj){ 		//calculates the ammount of juice that is produced from the given amount of peaches
		double juice;
		juice = _pj * 1.5;						//all statements within a the functions are within the scope of that function.
		return juice;
	}

	public double StrawJuice (double _sj){		//calculates the ammount of juice that is produced from the given amount of strawberries
		double juice;
		juice = _sj * 0.5;
		return juice;
	}

	public double GrapeJuice (double _gj){		//calculates the ammount of juice that is produced from the given amount of grapes
		double juice;
		juice = _gj * 2.5;
		return juice;
	}



}
