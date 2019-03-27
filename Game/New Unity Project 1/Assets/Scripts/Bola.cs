using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bola{

	int numero;
	Color color;


	public Bola(){
	}

	public Bola(int numero, Color color){
		this.numero = numero;
		this.color = color;
	}

	public int Numero {
		get {
			return this.numero;
		}
		set {
			numero = value;
		}
	}

	public Color Color {
		get {
			return this.color;
		}
		set {
			color = value;
		}
	}


}
