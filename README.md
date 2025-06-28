# Practice Project - Class Overview

This project targets **.NET 8** and contains several utility classes for practicing C# concepts.

---

## Classes

### 1. `Singleton`
Implements the Singleton design pattern, ensuring only one instance of the class exists.

- **Properties:**
  - `Instance`: Gets the singleton instance.
  - `Guid`: Returns a unique identifier for the instance.

---

### 2. `Extention`
Provides extension methods for string manipulation.

- **Methods:**
  - `CapitalizeLetter(this string text)`: Capitalizes the first letter of the string.

---

### 3. `LongestEvenWord`
Contains methods to find the longest word with an even number of characters in a sentence.

- **Methods:**
  - `FindLongestEvenWord(string input)`: Iterative approach to find the longest even-length word.
  - `FindLongestEvenWord2(string input)`: LINQ-based approach to find the longest even-length word.

---

### 4. `BinaryString`
Provides methods to check if a string contains only binary digits ('0' and '1').

- **Methods:**
  - `CheckIfStringIsBinary(string input)`: Checks using a foreach loop.
  - `CheckIfStringIsBinary2(string input)`: Checks using LINQ's `All` method.
  - `CheckIfStringIsBinary3(string input)`: Checks using LINQ's `Any` method.

---

### 5. `Program`
Entry point of the application. Demonstrates usage of utility classes and methods.

- **Methods:**
  - `Main(string[] args)`: Main method for running examples and tests.

---

## Notes

- All classes are in the `Practice` namespace.
- The project uses C# 12.0 features and is compatible with .NET 8.
