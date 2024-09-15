# Library Management System

Laboratory task nr.1 for OOP subject

This is a simple console-based Library Management System implemented in C#. The system allows users to add, remove, and print books in a library. It also provides a menu-driven interface for user interaction.

## Features

### 1. Add Book
- **Description**: Allows the user to add a new book to the library.
- **Input**:
  - Title: The title of the book (cannot be empty).
  - Author: The author of the book (if empty, defaults to "Anonymous").
  - Year: The publication year of the book (must be a valid integer).
  - ISBN: The ISBN of the book (must be a 13-digit number, if empty, defaults to "Missing").

### 2. Remove Book
- **Description**: Allows the user to remove a book from the library by its title.
- **Input**:
  - Title: The title of the book to be removed.

### 3. Print Books
- **Description**: Prints the details of all books currently in the library.
- **Output**:
  - Title, Author, Year, and ISBN of each book.

### 4. Exit
- **Description**: Exits the menu and terminates the program.

## Classes

### Library
- **Properties**:
  - `List<Book> Books`: A list to store the books in the library.
- **Methods**:
  - `AddBook(Book book)`: Adds a new book to the library.
  - `RemoveBook(string title)`: Removes a book from the library by its title.
  - `PrintBooks()`: Prints the details of all books in the library.
  - `OpenMenu()`: Displays the menu and handles user input.

### Book
- **Properties**:
  - `string Title`: The title of the book.
  - `string Author`: The author of the book.
  - `int Year`: The publication year of the book.
  - `string ISBN`: The ISBN of the book.

## Usage

1. **Run the Program**: Execute the `Main` method in the `Program` class.
2. **Interact with the Menu**: Follow the on-screen prompts to add, remove, or print books, or to exit the program.

## Example

```csharp
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        library.OpenMenu();
    }
}