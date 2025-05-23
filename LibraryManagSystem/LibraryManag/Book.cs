using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManag
{
    public class Book : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; private set; }
        public string Borrower { get; private set; }

        public Book(string title, string author, string isbn) 
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public void BorrowBook(string borrower)
        {
            if (IsBorrowed) 
            
                throw new InvalidOperationException($"'{Title}' is borrowed.");
            IsBorrowed = true;
            Borrower = borrower;    
        }

        public void ReturnBook() 
        {
            if (!IsBorrowed)
                throw new InvalidOperationException($"'{Title}' is not borrowed.");
            IsBorrowed=false;
            Borrower = null;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, ISBN: {ISBN} - {(IsBorrowed ? "Borrowed" : "Available")}";
        }
    }
}
