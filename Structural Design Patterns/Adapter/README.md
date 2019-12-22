# Adapter

Converts the interface of a class into another interface that the client expects. Adapter lets classes work together that otherwise could not have due to different interfaces.

## UML Diagram

![Adapter UML](https://github.com/prajnanBhuyan/Design-Patterns/blob/master/img/GoF-Design-Patterns-Structural-Patterns-Adapter.png)

## Participants

- Target
    - defines the specific interface that the client expects
- Adapter
    - adapts the <i>Adaptee</i> interface to the <i>Target</i> interface
- Adaptee
    - defines an existing interface that needs to be adapted
- Client
    - expects objects conforming to the <i>Target</i> interface