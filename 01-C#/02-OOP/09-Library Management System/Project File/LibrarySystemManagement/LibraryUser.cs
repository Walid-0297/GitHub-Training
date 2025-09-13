using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibrarySystemManagement
{
    internal class LibraryUser : User
    {
        // relation between class & class
        public int LibraryCard { get; set; } // Aggregation -> there is no mean for card existence without an actual user .
        public LibraryUser(string name)
        {
            Name = name;
        }

        public void BorrowBooks(Books book, Library library)
        {
            library.BoroowBook(book);
        }
    }
}
