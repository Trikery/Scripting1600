using UnityEngine;
using System.Collections;

public class Vars2 : MonoBehaviour {

	int po1 = 10;
	int po2 = 20;
	int po3 = 30;
	int gunpow = 5;

	float nightbot = 0.5f;
	float wabrebot = 2.5f;
	float weakbot = 5.678f;

	string potion = "Potion of ";
	string splash = "Splash ";
	string night = "Night Vision ";
	string water = "Water Breathing ";
	string weak = "Weakness ";

	int MixPotions (int Ingrediant1, int Ingrediant4){
		return Ingrediant1 + Ingrediant4;
	}
	int MixPotions (int Ingrediant1, int Ingrediant2, int Ingrediant3){
		return Ingrediant1 + Ingrediant2 + Ingrediant3;
	}

	void Start(){
		print (splash + potion + night + MixPotions (po1, gunpow).ToString());
		print (splash + potion + water + MixPotions (po2, gunpow).ToString());
		print (splash + potion + weak + MixPotions (po3, gunpow).ToString());
		print (potion + night + "/" + water + "/" + weak + MixPotions (po3, po1, po2));

	}
}
