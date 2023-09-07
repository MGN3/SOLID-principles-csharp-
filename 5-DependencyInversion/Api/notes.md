# Dependency Inversion principle

The key seems to be:
	1- Create an interface in a class
	2- Add those interfaces in another class as atributes
	3- The constructor will have to take these attributes into account.
	4- Doing is a contract without taking into account the implementation of what is contained in the Interface/class

The meaning of this is being able to test the code without the constraints of a database/file that is being used in the logic of the applicacion.
Specially usefull when coding following the Test Driven Development pattern.

There are many things I still need to comprehend properly surrounding the concept of Dependency Inversion Principle and parts of the code given in the Platzi course:

	- IEnumerable.
	- Mock (for tests).
	- WebApplicataion builder and other methods.
	- The specific order of the steps needed to create a code structure like this.
	- Things in [] like public void Add([FromBody] Student student) {
	- ...
