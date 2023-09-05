# Open-closed principle

A component must be open to be extended(scalable?) and closed to changes.

## How to extend components/code when asked for new modules/functionalities

Abstracts classes and interfaces are key to follow this principle.
C#, like java, don't allow multi-inheritance in order to avoid ambiguities regarding methods and properties with the same name.

So, without multi-inheritance, interfaces and abstract classes can be used to make classes and components more reusable, and make code more reusable in general.

## Class inheritance vs Interfaces inheritance
```
public class SubClass: MainClass

public class MyClass : IInterface1, IInterface2, IInterface3
```

### Clase Abstracta:

- Puede contener campos, propiedades, constructores y m�todos con o sin implementaci�n.
- Puede proporcionar implementaciones concretas (c�digo) para algunos o todos sus miembros.
- Las clases que heredan de una clase abstracta utilizan la herencia para adquirir sus caracter�sticas y, si es necesario, pueden anular (override) los m�todos o propiedades definidos en la clase abstracta.
- Permite compartir c�digo com�n y definir una estructura de clases base para la jerarqu�a.


### Interfaz:

- Solo puede contener definiciones de m�todos, propiedades, eventos y otros miembros, pero no puede proporcionar implementaciones.
- Las clases que implementan una interfaz deben proporcionar implementaciones para todos los miembros de la interfaz.
- Permite que las clases cumplan m�ltiples contratos, ya que una clase puede implementar varias interfaces.
- Se utiliza para definir un conjunto com�n de m�todos y propiedades que las clases deben proporcionar, independientemente de su jerarqu�a de herencia.

### Conclussion

Utiliza una clase abstracta cuando deseas proporcionar alguna implementaci�n predeterminada para los miembros y quieres establecer una jerarqu�a de herencia que comparta c�digo com�n.

Utiliza una interfaz cuando deseas definir un contrato que m�ltiples clases pueden cumplir sin importar su jerarqu�a de herencia, y cuando no necesitas proporcionar una implementaci�n predeterminada para los miembros.

## Exercise
We find that the program file doesn't respect the Single Responsability principle because the main class should make calls to methods, not implement the logic.

So we have to develop that logic inside the respective classes.

