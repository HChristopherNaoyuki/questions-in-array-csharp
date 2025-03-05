# Questions in Array

## Overview
The **Questions in Array** program allows the user to input a specified number of questions, store them in an array, and then display the list of questions entered. This C# console application makes use of basic input/output operations, exception handling, and array manipulation.

## Features
- Prompts the user to enter the number of questions.
- Accepts a series of questions as input.
- Stores the entered questions in an array.
- Displays all entered questions with their corresponding question number.

## Requirements
- .NET Framework (or .NET Core) for running C# applications.
- A C# compatible development environment (Visual Studio, Visual Studio Code, etc.).

## How to Use
1. **Run the Program**: Execute the program from your IDE or through the command line.
2. **Input Number of Questions**: When prompted, enter the number of questions you want to input. The program will ask for that many questions.
3. **Enter Questions**: For each question, type it into the console and press `Enter`.
4. **View Results**: After entering all questions, the program will display all the questions you entered.

## Example
### Input:
```
Please enter the number of question(s): 
3
Enter question number 1: 
What is your name?
Enter question number 2: 
Where do you live?
Enter question number 3: 
What is your favorite color?
```

### Output:
```
Questions entered: 

Question 1: What is your name?
Question 2: Where do you live?
Question 3: What is your favorite color?
```

## Exception Handling
The program includes a basic `try-catch` block to handle potential errors:
- If the user enters a non-numeric value for the number of questions, an exception will be caught and a message will be displayed.
- If any other unexpected errors occur during execution, they will be displayed in the error message.

## Conclusion
The **Questions in Array** program is a simple demonstration of using arrays, loops, and exception handling in C#. It can be a good starting point for learning basic console input/output and array manipulation.
