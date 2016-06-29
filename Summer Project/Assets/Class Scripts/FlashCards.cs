using UnityEngine;
using System.Collections;

public class FlashCards : MonoBehaviour {
		void Main() {
			int intValue = 10;
			string stringValue = "A String is ";

		print (stringValue + FloatTimesTwelve (intValue));
		}
		float FloatTimesTwelve (float intValue) {
			float inches = intValue * 12;
			return inches;
		}
}
