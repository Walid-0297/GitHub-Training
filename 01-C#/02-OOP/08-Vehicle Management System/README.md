# Vehicle Management System

A simple console application that demonstrates the use of **interfaces, abstraction, and polymorphism** in C# using a `Vehicle` system example.

##  Concepts Covered
- Interface definition and implementation
- Abstraction using interfaces
- Polymorphism with a collection of interface types

##  Description

We define an interface `IVehicle` that contains method signatures for starting and stopping a vehicle engine. Then, two classes `Car` and `Bike` implement this interface and provide their own definitions.

##  Features

- `Car` and `Bike` implement the `IVehicle` interface.
- A list of `IVehicle` objects holds both car and bike instances.
- Each vehicle's specific version of `StartEngine()` and `StopEngine()` is called using polymorphism.



