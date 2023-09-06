public class Singleton {
	// Variable privada que almacena la única instancia de la clase.
	private static Singleton instance;

	// Constructor privado para evitar la creación de instancias desde fuera de la clase.
	private Singleton() {
	}

	// Método público para obtener la instancia única de la clase.
	public static Singleton GetInstance() {
		if (instance == null) {
			instance = new Singleton();
		}
		return instance;
	}

	// Método de ejemplo de la instancia.
	public void SomeMethod() {
		Console.WriteLine("Método de la instancia Singleton");
	}
}

/*
class Program {
	static void Main() {
		// Obtener la instancia única del Singleton.
		Singleton singleton = Singleton.GetInstance();

		// Llamar a un método de la instancia.
		singleton.SomeMethod();

		// Intentar crear una nueva instancia (no se permite).
		// Singleton otroSingleton = new Singleton(); // Esto genera un error de compilación.

		// Comprobar que ambas variables hacen referencia a la misma instancia.
		if (singleton == Singleton.GetInstance()) {
			Console.WriteLine("Ambas variables hacen referencia a la misma instancia Singleton.");
		}
	}

}
*/