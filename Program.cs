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
        Books.RemoveAll(b => b.Title == title);
    }

    public void PrintBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}, ISBN: {book.ISBN}");
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

        Book book1 = new Book { Title = "Book One", Author = "Author One", Year = 2001, ISBN = "111-1111111111" };
        Book book2 = new Book { Title = "Book Two", Author = "Author Two", Year = 2002, ISBN = "222-2222222222" };

        library.AddBook(book1);
        library.AddBook(book2);

        Console.WriteLine("Books in library after adding:");
        library.PrintBooks();

        library.RemoveBook("Book One");

        Console.WriteLine("Books in library after removing 'Book One':");
        library.PrintBooks();
    }
}