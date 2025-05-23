using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManag
{
    public class EBook : Book
    {
        public string FileFormat { get; set; }
        public EBook(string title, string author, string isbn, string fileFormat) : base(title, author, isbn)
        {
            FileFormat = fileFormat;
        }
    }
}
