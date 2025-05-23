using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManag
{
    public interface IBorrowable
    {
        bool IsBorrowed { get; }
        void BorrowBook(string borrower);
        void ReturnBook();

    }
}
