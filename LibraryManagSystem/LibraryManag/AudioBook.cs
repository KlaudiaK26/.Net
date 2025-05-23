using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManag
{
    public class AudioBook : Book
    {
        public double Duration { get; set; }
        public AudioBook(string title, string author, string isbn, double duration) : base(title, author, isbn) 
        {
            Duration = duration;
        }
    }
}
