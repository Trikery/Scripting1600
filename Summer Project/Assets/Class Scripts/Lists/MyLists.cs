using UnityEngine;
using System.Collections;
using System.Collections.Generic;  //This is required for using Lists
using UnityEngine.UI;  //This is required to access Unity's New GUI System

namespace StudioThorn{
	public class MyLists : MonoBehaviour {


		public List<string> playerNames = new List<string> ();    //what does new mean
		//Type of List^
		public Text myInputTest;


		void OnMouseUp () {
			playerNames.Add (myInputTest.text);
			
		}
	}
}
