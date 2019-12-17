# Factory Method

Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

## UML Diagram

![Factory Method UML](https://github.com/prajnanBhuyan/Design-Patterns/tree/master/img/GoF-Design-Patterns-Creational-Patterns-Factory-Method-1.png")

## Participants

- Product
    - defines the interface of objects that the factory method creates
- ConcreteProduct
    - implements the Product interface
- Creator
    - declares the <i>factory method</i>, which returns an object of the type Product
- ConcreteCreator
    - overrides the factory method to return an instance of a ConcreteProduct