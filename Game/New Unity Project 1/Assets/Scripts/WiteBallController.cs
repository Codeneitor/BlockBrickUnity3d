using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiteBallController : MonoBehaviour {
	public GameObject tacoModel;
	public GameObject bolaBlancaModel;
	public Vector3 posicion;
	public float Velocidad;
	public float direccion;
	public float fuerzaImpacto = 0;

	public bool golpeTaco;
	public bool moviendo;
	public bool golpeBola;
	public int bolaGolpeada;
	public bool hayEntronada;
	public float bolaEntronada;
	public string Mensaje;

	public Color color;

	// Use this for initialization
	void Start () {
		//Fetch the Renderer from the GameObject
		MeshRenderer rend = bolaBlancaModel.GetComponent<MeshRenderer>();
		//Set the main Color of the Material to green
		rend.material.shader = Shader.Find("_Color");
		rend.material.SetColor("_Color", color);

		//Find the Specular shader and change its Color to red
		rend.material.shader = Shader.Find("Specular");
		rend.material.SetColor("_SpecColor", Color.blue);
	}


	public float velocidadInicialBola = 600f;
	public float velocidadYBola = 600f;
	public float efectoBola = 0f;

	private Rigidbody rb;
	private bool bolaEnJuego;

	void Awake(){
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame

	void Update () {
		if(Input.GetButtonDown("Fire1") && bolaEnJuego == false){
			transform.parent = null;
			bolaEnJuego = true;
			rb.isKinematic = false;
			rb.AddForce (new Vector3(velocidadInicialBola, -10f, 300f));
			bolaEnJuego = false;

			//
		}
		
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag=="taco"){



		}

	}

}
