using UnityEngine;
using System;

public class Varfun : MonoBehaviour{

	int five = 5;
	void Start(){
		five = twice (five);
		Debug.Log (five);
	}
	int twice(int number){
		int ret;
		ret = number * 2;
		return ret;

	}

	}

