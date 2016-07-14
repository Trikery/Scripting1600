using UnityEngine;
using System.Collections;

public class ProgramThree : MonoBehaviour {

	public string[] toDos;
	public string finishedTask;

	void OnMouseDown ()
	{
		print ("To Do List");
		foreach (string list in toDos) 
		{
			print ("You Need to " + list);

		}
		foreach (string list in toDos) 
		{
			if (finishedTask == list) {
				print (finishedTask + " completed.  Good Job!");
				print (toDos.Length - 1 + " tasks still need to be done");
			}

		}
	}
}
