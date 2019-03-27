using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour {
	private Usuario user;
	public string usuario;


	// Use this for initialization
	void Start () {
		user = new Usuario ();
		user.Nombre = "Brayan Novoa";
		user.Email = "bnovoa.linux@gmail.com";
		usuario = user.Nombre;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void agregarPuntosMalos(Usuario usuario, int puntos){
	}

	public void borrarPuntosMalos(Usuario usuario, int puntos){
	}


}
