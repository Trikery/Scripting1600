using UnityEngine;
using System.Collections;

namespace StudioThorn {
	public class GameController : MonoBehaviour {

		public GameObject GameControl;
		// Create a simple Character Select Program'
		// Select between two characters
		// Print Name of Character
		// Make other character vanish
		// (optional) bring other character object to the center.

		void ChangeGame (){
			switch (EnumController.playGame) {
			case EnumController.GamePlay.StartMenu:
				GameControl.SetActive (false);
				print ("Press Start!");
				break;
			case EnumController.GamePlay.CharacterSelection:
				GameControl.SetActive (true);
				print ("Select Your Character!");
				this.gameObject.SetActive (false);
				break;
			}
		}
		void Start (){
			ChangeGame ();
		}

		void OnMouseDown () {
			EnumController.playGame = EnumController.GamePlay.CharacterSelection;
			ChangeGame ();
		}
	
	}
	
}
