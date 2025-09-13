using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibrarySystemManagement
{
    internal class Liberian : User
    {
        public int EmployeeNumber { get; set; }

        public Liberian(string name)
        {
            Name = name;
        }
        public void AddBooks(Books NewBook, Library library)
        {
            library.AddBooks(NewBook, library); // association 
        }
        public void RemoveBooks(Books NewBook, Library library)
        {
            library.RemoveBooks(NewBook, library);
        }
    }
}
