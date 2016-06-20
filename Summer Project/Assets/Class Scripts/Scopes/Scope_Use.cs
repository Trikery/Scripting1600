using UnityEngine;
using System.Collections;

public class Scope_Use : MonoBehaviour {

	private Scope_Test MyFruit;
	public int newApples;
	public int newOranges;
	public int newGrapes;

	void OnMouseDown () {
		MyFruit = new Scope_Test ();
		MyFruit.AddApples (newApples);
		MyFruit.AddApples (newApples);
		MyFruit.AddOrange (newOranges);
		MyFruit.grapes = newGrapes;

		int allFruit = MyFruit.MixFruit ();
		print (allFruit);
	}
}