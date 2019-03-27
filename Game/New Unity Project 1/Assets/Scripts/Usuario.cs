public class Usuario {

	int id;
	string nombre;
	string email;
	public Usuario(){
		id = 0;
		nombre = "";
		email = "";
	}
	public Usuario(int id, string nombre, string email){
		this.id=id;
		this.nombre=nombre;
		this.email=email;
	}
	public int Id {
		get {
			return this.id;
		}
		set {
			id = value;
		}
	}

	public string Nombre {
		get {
			return this.nombre;
		}
		set {
			nombre = value;
		}
	}

	public string Email {
		get {
			return this.email;
		}
		set {
			email = value;
		}
	}
}
