# MathQuiz

> This project was developed as a **FINKI course project** (Faculty of Computer Science and Engineering, Ss. Cyril and Methodius University in Skopje).

MathQuiz is a Windows desktop application that tests mental arithmetic. It generates random addition, subtraction and multiplication questions, scores each answer, and shows running statistics for the session.

## Features

- Random questions with operands from 0 to 99 and the operators `+`, `−` and `×`.
- Input validation: the answer box rejects anything that is not a whole number.
- Points based on difficulty:
  - `+` and `−` award points equal to the total number of digits in the two operands.
  - `×` awards three times that amount.
  - A wrong answer costs 2 points.
- A statistics panel that shows the number of questions answered, the lowest and highest points, the total, and the average.

## Getting started

### Prerequisites

- Windows
- Visual Studio with the .NET desktop development workload
- .NET Framework 4.7.2 developer pack

### Run

1. Open `mathquiz.sln` in Visual Studio.
2. Press **F5** to build and run.

## Project structure

| File | Purpose |
|---|---|
| `Form1.cs` | Main window: starts questions and updates the statistics |
| `QuestionForm.cs` | Dialog that shows a question and collects the answer |
| `Question.cs` | Question model: operands, operator, expected result and points |
| `Program.cs` | Application entry point |

## Tech stack

C# · .NET Framework 4.7.2 · Windows Forms

## Author

**Kristijan Zafirovski**
