using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBallController : MonoBehaviour {

	HoleController holeController;
	public GameObject bolaColorModel;
	public Color color;
	public int numero;
	Bola bola;

	// Use this for initialization
	void Start () {
		//HoleController holeController = (HoleController)GetComponent ("HoleController");
		holeController=GameObject.Find ("Holes").GetComponent<HoleController>();
		//bola = new Bola (numero, color);

		MeshRenderer rend = bolaColorModel.GetComponent<MeshRenderer>();
		//Set the main Color of the Material to green
		rend.material.shader = Shader.Find("_Color");
		rend.material.SetColor("_Color", color);

		//Find the Specular shader and change its Color to red
		rend.material.shader = Shader.Find("Specular");
		rend.material.SetColor("_SpecColor", Color.white);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		//bola = new Bola ();
		if(col.gameObject.tag=="holes"){
			bola = new Bola (numero, color);
			//bola.Numero = numero;
			//bola.Color = color;
			//Debug.Log ("Soy la bola " + bola.Numero );
			Destroy (gameObject);
			holeController.bolaEntronada (bola);

		}
		
	}
}
