using System;
using System.Collections.Generic;
using LibraryManag;

namespace LibraryApp
{
    class Program
    {
        static List<Book> library = new List<Book>();

        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nLibrary Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add EBook");
                Console.WriteLine("3. Add AudioBook");
                Console.WriteLine("4. Borrow Item");
                Console.WriteLine("5. Return Item");
                Console.WriteLine("6. List All Items");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1": AddBook(); break;
                    case "2": AddEBook(); break;
                    case "3": AddAudioBook(); break;
                    case "4": BorrowBook(); break;
                    case "5": ReturnBook(); break;
                    case "6": ListBooks(); break;
                    case "7": exit = true; break;
                    default: Console.WriteLine("Invalid option."); break;

                }
            }
        }

        static void AddBook()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Author: ");
            string author = Console.ReadLine();

            Console.WriteLine("ISBN: ");
            string isbn = Console.ReadLine();

            library.Add(new Book(title, author, isbn));
            Console.WriteLine("New Book Added");
        }

        static void AddEBook()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Author: ");
            string author = Console.ReadLine();

            Console.WriteLine("ISBN: ");
            string isbn = Console.ReadLine();

            Console.WriteLine("File Format: ");
            string fileFormat = Console.ReadLine();

            library.Add(new EBook(title, author, isbn, fileFormat));
            Console.WriteLine("New EBook Added");
        }

        static void AddAudioBook()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Author: ");
            string author = Console.ReadLine();

            Console.WriteLine("ISBN: ");
            string isbn = Console.ReadLine();

            Console.WriteLine("Duration (h): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double duration))
            {
                library.Add(new AudioBook(title, author, isbn, duration));
                Console.WriteLine("New AudioBook Added");
            }
            else 
            {
                Console.WriteLine("Error with duration format");
            }
        }

        static void BorrowBook() 
        {
            Console.WriteLine("Title of the book: ");
            string title = Console.ReadLine();

            Book book = null;
            foreach (var item in library) 
            {
                if (item.Title.ToLower() == title.ToLower()) {
                    book = item;
                    break;
                }
            }

            if (book == null) 
            {
                Console.WriteLine("Book not found!");
                return;
            }

            Console.WriteLine("Name of the borrower: ");
            string borrower = Console.ReadLine();

            try
            {
                book.BorrowBook(borrower);
                Console.WriteLine("Book borrowed successfully!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error is: {ex.Message}");
            }
        }

        static void ReturnBook() 
        {
            Console.WriteLine("Enter Title of book to return: ");
            string title = Console.ReadLine();
            Book book = null;
            foreach (var item in library) 
            {
                if (item.Title.ToLower() == title.ToLower()) 
                {
                    book = item;
                    break;  
                }
            }

            if ( book == null ) 
            {
                Console.WriteLine("Book not found!");
                return;
            }

            try
            {
                book.ReturnBook();
                Console.WriteLine("Book returned successfully");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error is: {ex.Message}");
            }
        }

        static void ListBooks() 
        {
            if (library.Count == 0) 
            {
                Console.WriteLine("Library doesn't have any books.");
                return;
            }

            Console.WriteLine("\nLibrary Collection:");
            foreach (var item in library) 
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}

