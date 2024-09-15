class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(string title)
    {
        Books.RemoveAll(b => b.Title == title); // For each book check if the title matches the one we're looking for and nuke it.
    }

    public void PrintBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}, ISBN: {book.ISBN}");
        }
    }

    public void OpenMenu()
{
    while (true)
    {
        Console.WriteLine("1. Add book");
        Console.WriteLine("2. Remove book");
        Console.WriteLine("3. Print books");
        Console.WriteLine("4. Exit");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter title:");
                string title;
                if (string.IsNullOrWhiteSpace(title = Console.ReadLine()))
                {
                    Console.WriteLine("Title cannot be empty. Please enter a valid title.");
                    continue;
                }

                Console.WriteLine("Enter author:");
                string author;
                if (string.IsNullOrWhiteSpace(author = Console.ReadLine()))
                {
                    Console.WriteLine("Authon line empty. Will consider as Anonymous.");
                    author = "Anonymous";
                }
                Console.WriteLine("Enter year:");
                int year;
                if (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.WriteLine("Invalid year. Please enter a valid number.");
                    continue;
                }
                Console.WriteLine("Enter ISBN:");
                string isbn;
                if (string.IsNullOrWhiteSpace(isbn = Console.ReadLine()))
                {
                    Console.WriteLine("ISBN is empty. Will consider as missing.");
                    isbn = "Missing";
                } else if (isbn.Length != 13)
                {
                    Console.WriteLine("Invalid ISBN. Please enter a valid 13-digit ISBN.");
                    continue;
                }
                
                Book book = new Book { Title = title, Author = author, Year = year, ISBN = isbn };
                AddBook(book);
                break;
            case 2:
                Console.WriteLine("Enter title:");
                string titleToRemove = Console.ReadLine();
                RemoveBook(titleToRemove);
                break;
            case 3:
                PrintBooks();
                break;
            case 4:
                return;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
}

class Book
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public int Year { get; set; } = 0;
    public string ISBN { get; set; } = string.Empty;
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        /*
        Book book1 = new Book { Title = "Book One", Author = "Author One", Year = 2001, ISBN = "111-1111111111" };
        Book book2 = new Book { Title = "Book Two", Author = "Author Two", Year = 2002, ISBN = "222-2222222222" };
        
        library.AddBook(book1);
        library.AddBook(book2);

        Console.WriteLine("Books in library after adding:");
        library.PrintBooks();

        library.RemoveBook("Book One");

        Console.WriteLine("Books in library after removing 'Book One':");
        library.PrintBooks();
        */
        library.OpenMenu();
    }
}