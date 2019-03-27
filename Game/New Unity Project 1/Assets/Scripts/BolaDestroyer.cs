using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaDestroyer : MonoBehaviour {
	void OnCollisionEnter (Collision col){
		if(col.gameObject.tag=="balls"){
			Destroy (col.gameObject);
		}
		
	}
}
