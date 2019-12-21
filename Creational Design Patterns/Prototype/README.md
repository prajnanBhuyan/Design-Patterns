# Prototype

Specify the kind of object to create using a prototypical instance, and create new object by copying this prototype

## UML Diagram

![Prototype UML](https://github.com/prajnanBhuyan/Design-Patterns/blob/master/img/GoF-Design-Patterns-Creational-Patterns-Prototype.png)

## Participants

- Prototype
    - declares an interface for cloning itself
- ConcretePrototype
    - implements an operation for cloning itself
- Client
    - creates a new object by asking <i>Prototype</i> to clone itself