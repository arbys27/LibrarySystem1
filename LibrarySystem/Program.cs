using System;


class LibrarySystem
{
    static List<string> books = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n********** Library Management System **********");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ViewBooks();
                    break;
                case "3":
                    UpdateBook();
                    break;
                case "4":
                    DeleteBook();
                    break;
                case "5":
                    Console.WriteLine("Exiting Library System...");
                    return;
                default:
                    Console.WriteLine("Invalid option! Please try again.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();
        books.Add(title);
        Console.WriteLine($"Book '{title}' added successfully.");
    }

    static void ViewBooks()
    {
        Console.WriteLine("\n--- Book List ---");
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
        }
        else
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
        }
    }

    static void UpdateBook()
    {
        ViewBooks();
        Console.Write("Enter book number to update: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= books.Count)
        {
            Console.Write("Enter new book title: ");
            string newTitle = Console.ReadLine();
            books[index - 1] = newTitle;
            Console.WriteLine("Book updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid book number.");
        }
    }

    static void DeleteBook()
    {
        ViewBooks();
        Console.Write("Enter book number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= books.Count)
        {
            Console.WriteLine($"Book '{books[index - 1]}' deleted.");
            books.RemoveAt(index - 1);
        }
        else
        {
            Console.WriteLine("Invalid book number.");
        }
    }
}
