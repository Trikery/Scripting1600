using UnityEngine;
using System.Collections;

public class Whiles : MonoBehaviour {

	public float xDistance = 10;
	Vector3 pos;

	IEnumerator MoveInX (){
		while (pos.x <= xDistance) {
			pos.x += 0.1f;
			transform.position = pos;
			yield return new WaitForSeconds (0.1f);
		}
		xDistance = 20;
		StartCoroutine (MoveInX ());
	}

	void OnMouseDown () {
		xDistance += 1;
		StartCoroutine (MoveInX ());
	}
}
