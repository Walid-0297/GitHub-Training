# Polymorphism 

This project demonstrates **Polymorphism** in C# using virtual and override methods.

## 👨‍🏫 Concepts Covered

- Inheritance
- Virtual and Override Methods
- Runtime Polymorphism using base class references

## 📌 Description

We define a base class `Animal` with a virtual method `Speak()`. Then, we define two child classes `Dog` and `Cat` that override this method.

In `Main()`, we create objects of each class and call the `Speak()` method using a reference of type `Animal`, which shows how the method call behaves differently depending on the actual object — this is **runtime polymorphism**.



