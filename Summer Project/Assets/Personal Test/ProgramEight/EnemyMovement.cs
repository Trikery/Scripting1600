using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public IEnumerator Mob (){
		if (this.transform.position.x > -13) {
			this.transform.Translate (0, .5f, 0);
			yield return new WaitForSeconds (.1f);
		}
			else{
			this.transform.Translate (0, -26, 0);
				
			}
		
		}
	
	}
