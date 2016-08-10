using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using StudioThorn;

namespace StudioThorn{
public class Lists1 : MonoBehaviour {

/* Design a program that gives Two fruit varying in quantities.
 * print an execution message
 * Click the fruit to add them to the players inventory.
 * deselect the fruit with X to drop the fruit
 * Eat the Fruit with Space and subtract one fruit
 * If no more fruit print out of fruit
 * If no more fruit and user tries again, player dies.
 * Print all of these
 */ 
	public List<StudioThorn.Lists2> fruits = new List<StudioThorn.Lists2> (); //Create List

	void Start (){
			print ("You have to pick up fruit to survive!"); // print an execution message
			print ("Click fruit to pick it up, X to drop it, Space to eat");
		}

	void Update (){
			if (Input.GetKeyUp (KeyCode.X) && fruits.Count > 0) { //if player presses X and there is fruit in the inventory, then element 0 is removed and returned
			fruits[0].gameObject.SetActive (true);  //game object reappears
			fruits.RemoveAt (0);  //remove object from inventory
			}
			if (Input.GetKeyUp (KeyCode.Space) && fruits.Count > 0 && fruits [0].quantity > 0) {  //if + in inventory & quantity is + execute
				fruits [0].quantity--;  //subtract quantity from object
				print ("You Ate some Fruit AND LIVE!!!  " + fruits [0].quantity + " fruit remains."); //print
				if (fruits.Count > 0 && fruits [0].quantity <= 0) { //if run out of fruit print this as well
					fruits.RemoveAt (0);
					print ("Ran out of fruit");
				} else {
				}
			}
			else if (Input.GetKeyUp (KeyCode.Space ) && fruits.Count == 0) {  // if space and count is zero and quantity is zero execute
				print ("NO MORE FRUIT!!!  YOU DIED!");  //no more fruit, YOu die
			}
		}
	}
}
