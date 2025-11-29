# 📝 Console To-Do List Application

A robust, console-based Task Management application built with **C#** and **.NET**. 
This project demonstrates the fundamentals of **Object-Oriented Programming (OOP)**, **CRUD operations**, and **Separation of Concerns** (Business Logic vs. UI).

## 🚀 Features

* **Add Tasks:** Create new tasks with ease. Includes null safety checks.
* **List Tasks:** View all tasks with their current status (Completed/Continues), IDs, and creation dates.
* **Complete Tasks:** Mark specific tasks as "Completed".
    * *Logic:* Includes validation to prevent marking an already completed task.
    * *Filtering:* Shows only active tasks when selecting a task to complete.
* **Delete Tasks:** Remove tasks permanently by ID.
    * *Safety:* Includes input validation (TryParse) to prevent crashes if non-numeric values are entered.
* **User Experience (UX):** Clean console interface with screen clearing and input validation.

## 🏗️ Architecture

The project follows a modular structure to ensure clean code principles:

1.  **`ToDoItem.cs` (Model):** * Represents the data structure of a single task (ID, Title, IsCompleted, CreatedDate).
2.  **`TaskManager.cs` (Business Logic):** * Manages the list of tasks.
    * Handles logical operations like Adding, Finding, Deleting, and Completing tasks.
    * Does not interact directly with the Console (Separation of Concerns).
3.  **`Program.cs` (User Interface):** * Handles user input/output.
    * Connects the user to the `TaskManager`.
    * Manages the main application loop and menu system.

## 🛠️ Technologies Used

* C#
* .NET SDK
* System.Collections.Generic (List Structures)

## 🔮 Future Improvements

* [ ] saving tasks to a file (txt/json) for data persistence.
* [ ] Adding priority levels to tasks.
* [ ] Search functionality by task title.

---

*This project was developed for educational purposes to master C# Classes and OOP logic.*
