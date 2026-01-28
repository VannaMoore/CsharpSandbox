# ConsoleSkillLab

**ConsoleSkillLab** is a C# console application focused on practicing core programming fundamentals through small, menu-driven exercises.  
This project is intentionally simple and framework-free, emphasizing logic, control flow, and clean organization as a way to build muscle memory and reinforce good coding practices.

---

## Purpose

This project exists to strengthen understanding of:
- C# syntax and core language features
- Loops (`for`, `foreach`, `while`, `do-while`)
- Arrays and Lists
- Conditional logic
- Input validation
- Console-based program flow
- Organizing code across multiple files

---

## Exercises

All exercises are accessible through a console menu.

### Numbers Bucket Game
Classifies a user-entered number as:
- Positive / Negative / Zero
- Even or Odd

Practices conditional logic and modulus operations.

---

### Age Checker
- Prompts the user for a birth year
- Calculates age based on whether the user has had a birthday this year
- Determines eligibility for driving, voting, drinking, and gambling

Practices input validation, branching logic, and reusable helper methods.

---

### Create a List
- Allows the user to dynamically build a list of strings
- Ends input when the user types `done`
- Prints the final list using a `foreach` loop

Practices lists, loops, and user-driven termination conditions.

---

### Sum and Average
- Prompts the user to enter 5 numbers
- Stores values in an array
- Calculates and displays the sum and average

Practices arrays, loops, and basic arithmetic operations.

---

### Reverse Numbers List
- Prompts the user to enter 5 integers into an array
- Prints the numbers in reverse order without modifying the array
- Uses loop-based iteration instead of recursion

Practices array traversal, index logic, and safe loop-based repetition.

---

### Letter Bucket Game
- Prompts the user to enter a string.
- Normalizes input using `ToLower()`.
- Iterates through the string using a `foreach` loop.
- Classifies each character as a vowel, consonant, or neither.
- Prints the total count of vowels and consonants to the console.

---

## Utilities
### Helpers Utility Class
Provides reusable helper methods for user input, validation, and classification logic shared across console exercises. This class reduces repetition and keeps individual game files focused on their core functionality.

### Helper Methods
- Continue()
  Prompts the user to continue or return to the main menu and returns a bool based on the user’s input.

- PickAnyNumber()
  Displays a standardized prompt for entering a positive or negative number.

- UserBirthYear()
  Prompts the user for a birth year, validates numeric input using TryParse, and re-prompts until valid input is provided.

- ConsonantOrVowelOrNeither()
  Receives a normalized char as input and classifies it as a vowel, consonant or neither.

ConsonantOrVowelOrNeither(char letter)
Classifies a character as a vowel, consonant, or neither, supporting the Letters Bucket Game.
---

## Project Structure
```
ConsoleSkillLab/
│
├── Exercises/
│ ├── AgeChecker.cs
│ ├── CreateAList.cs
│ ├── NumbersBucketGame.cs
│ ├── ReverseListPrint.cs
│ └── SumAverage.cs
│
├── Utilities/
│ └── Helpers.cs
│
├── Menu.cs
├── Program.cs
└── README.md
```

