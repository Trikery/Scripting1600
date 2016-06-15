using UnityEngine;
using System.Collections;

public class WhilesTwo : MonoBehaviour {

	void Update (){
		if (transform.position.x <= 10)
			transform.Translate (0.1f, 0,0);

		print ("Update");
	}

}
