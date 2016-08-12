using UnityEngine;
using System.Collections;

public class ReloadLevel : MonoBehaviour {
	
	public void LoadLevel () {
		Application.LoadLevel ("GamePlay");  //returning obsolete but functions anyway
	}

}
