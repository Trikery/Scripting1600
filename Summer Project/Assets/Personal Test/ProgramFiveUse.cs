using UnityEngine;
using System.Collections;

public class ProgramFiveUse : MonoBehaviour {
	
	private ProgramFive Juices;	//Assign an Identifier to ProgramFive to be used in this script

	public double peaches;		//three double variables are defined to be used as arguments
	public double strawberries;	//All of these are public so the user can alter them in Unity
	public double grapes;
	private double mixjuice;	//This is private.  It's value is based on the product of other values.

	void OnMouseDown (){
		Juices = new ProgramFive ();	//I'm not really sure what this is...  I guess it's an instance.

		mixjuice = Juices.PeachJuice (peaches) + Juices.StrawJuice(strawberries) + Juices.GrapeJuice(grapes);  //combine the values of the three functions in ProgramFive

		print ("Amount of Peache Juice Equals " + Juices.PeachJuice (peaches));  //Call each funtion with there parameters assigned to the variables in this program
		print ("Amount of Strawberry Juice Equals " + Juices.StrawJuice (strawberries));
		print ("Amount of Grape Juice Equals " + Juices.GrapeJuice (grapes));
		print ("Total Amount of Juice Equals " + mixjuice);

		if (mixjuice == 3)		//an if statement that states the outcome of the amount of juice that you made
			print ("The Kopaians Drank and Were Satisfied!");
		else if (mixjuice < 3)
			print ("There wasn't enough Juice to Go around and the Kopaians Starved!");
		else if (mixjuice > 3)
			print ("There was too much juice!  The Ship was drenched in Blood.  No Kopaians Survived!");
		


	}
}
