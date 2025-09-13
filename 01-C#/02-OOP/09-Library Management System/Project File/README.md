# Library System Management

This project demonstrates core Object-Oriented Programming (OOP) concepts in C#, such as **Encapsulation, Inheritance, Abstraction, and Associations between classes**.  
It simulates a simple library system where a librarian can add or remove books, and a regular user can view or borrow books.

---

## Overview

The project is divided into multiple classes, each with its own responsibility, following OOP principles.

---

## Program.cs

**Purpose:**  
- Entry point of the application.  
- Handles user interaction through the console.  
- Creates objects from other classes and calls their methods.

**Responsibilities:**  
- Ask whether the user is a Librarian or a Regular User.  
- If Librarian: add, remove, or display books.  
- If User: display or borrow books.

**Concepts Used:**  
Object creation with constructors, loops, input validation, and `switch` statements.

---

## Library.cs

**Purpose:**  
Represents the library itself.  
It encapsulates the data about books and provides methods to manipulate them.

**Fields (private):**  
- `Books[] Books` : stores current books.  
- `int NumberOfCurrentBooks` : tracks how many books exist.  
- `Books[] BorrowedBooks` : stores borrowed books.  
- `int NumberOfBorrowedBooks` : tracks borrowed books count.

**Methods:**  
- `DisplayBooks()` : loops through books and prints their details.  
- `AddBooks(Books book, Library library)` : adds a new book to the library.  
- `RemoveBooks(Books book, Library library)` : removes a book from the library.  
- `BoroowBook(Books book)` : moves a book to the borrowed list.

**Concepts Used:**  
Encapsulation and methods as class behaviors.

---

## Books.cs

**Purpose:**  
Represents a single book entity.

**Properties:**  
- `string Title`  
- `string Author`  
- `int Year`

**Concepts Used:**  
Auto‑implemented properties for clean encapsulation.

---

## User.cs (Abstract Class)

**Purpose:**  
Base class for all user types in the system.

**Members:**  
- `string Name` : stores the user’s name.  
- `DisplayBooks(Library library)` : allows viewing books.

**Concepts Used:**  
Abstraction — cannot instantiate `User` directly; it is only for inheritance.

---

## LibraryUser.cs

**Purpose:**  
Represents a regular library user who can borrow books.

**Members:**  
- `int LibraryCard` : user’s card number.  
- Constructor to set user name.  
- `BorrowBooks(Books book, Library library)` : calls the library method to borrow a book.

**Concepts Used:**  
Inheritance from `User`, and association with `Library`.

---

## Librarian.cs

**Purpose:**  
Represents a librarian with permissions to manage books.

**Members:**  
- `int EmployeeNumber` : librarian’s employee number.  
- Constructor to set librarian name.  
- `AddBooks(Books newBook, Library library)` : adds a book.  
- `RemoveBooks(Books newBook, Library library)` : removes a book.

**Concepts Used:**  
Inheritance from `User`, and association with `Library`.

---

## LibraryCard.cs

**Purpose:**  
Represents a library card.

**Members:**  
- `int MembershipNumber`

**Concepts Used:**  
Simple data holder class and aggregation (a LibraryUser may have a LibraryCard).

---

## Concepts Demonstrated

| Concept        | Where It’s Used                                                                 |
|----------------|-------------------------------------------------------------------------------|
| Encapsulation | Private fields and methods in `Library` controlling access.                   |
| Inheritance   | `Librarian` and `LibraryUser` inherit from `User`.                            |
| Abstraction   | `User` is abstract, cannot be instantiated directly.                          |
| Aggregation   | `LibraryUser` may contain a `LibraryCard`.                                     |
| Association   | `Librarian` and `LibraryUser` interact with `Library` through public methods. |

---

## How to Run

1. Build and run the project.
2. Choose your role: Librarian (L) or User (R).
3. Follow the console prompts to manage or borrow books.

---
