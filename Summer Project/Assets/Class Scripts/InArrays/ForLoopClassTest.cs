using UnityEngine;
using System.Collections;

public class ForLoopClassTest : MonoBehaviour {

	public string[] playerNames;
	public string search;


	void Start () 
	{
		foreach (string _name in playerNames) 
		{
			if (_name == search)
				print (_name);

		}
	}
}
