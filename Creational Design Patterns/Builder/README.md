# Builder

Separates the construction of a complex object from its representation si that the same construction process can create different representations.

## UML Diagram

![Abstract Factory UML](https://github.com/prajnanBhuyan/Design-Patterns/blob/master/img/GoF-Design-Patterns-Creational-Patterns-Builder.png)

## Participants

- Director
    - constructs a complex object using the <i>Builder</i> interface
- Builder
    - specifies an abstract interface for building parts of a <i>Product</i> object
    - provides an interface for retrieving the product
- ConcreteBuilder
    - builds the parts of a <i>Product</i> object and provides means of retrieving it by implementing <i>Builder</i>
- Product
    - represents the complex object under construction
