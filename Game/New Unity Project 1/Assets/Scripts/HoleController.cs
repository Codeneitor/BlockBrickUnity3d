using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleController : MonoBehaviour {
	public ScriptableObject script;
	public Bola bola;
	GameObject Bola;

	// Use this for initialization
	void Start () {
		//bola = new Bola ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void bolaEntronada(Bola bola){
		Debug.Log ("Bola " + bola.Numero);
	}
	void OnCollisionEnter (Collision col){
		if(col.gameObject.tag=="balls"){
			//Bola bola = new Bola ();//col.gameObject.GetComponent<Bola>;
			//int num = bola.Numero;
			//Debug.Log ("Bola Entronada: "+ num);
			//GameObject parent =col.gameObject.GetComponentInParent<GameObject>;
			//Debug.Log ("Bola Entronada: "+ parent.name);
			//Debug.Log ("Bola Entronada: "+ gameObject.transform.parent.name);
			//Debug.Log ("Bola Entronada: "+ col.gameObject.GetComponentInParent<GameObject>);
			
			//Destroy (col.gameObject);
		}

	}


}
