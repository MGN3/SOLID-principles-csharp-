# Open-closed principle

A component must be open to be extended(scalable?) and closed to changes.

## How to extend components/code when asked for new modules/functionalities

Abstracts classes and interfaces are key to follow this principle.
C#, like java, don't allow multi-inheritance in order to avoid ambiguities regarding methods and properties with the same name.

So, without multi-inheritance, interfaces and abstract classes can be used to make classes and components more reusable, and make code more reusable in general.

```
public class SubClass: MainClass

public class MyClass : IInterface1, IInterface2, IInterface3
```

## Exercise
We find that the program file doesn't respect the Single Responsability principle because the main class should make calls to methods, not implement the logic.

So we have to develop that logic inside the respective classes.

