using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemManagement
{
    internal abstract class User  // for LibraryUser & Liberian to inherent from , but can't create an object from the abstract .
    {
        public string Name { get; set; }
        public void DisplayBooks(Library library)
        {
            library.DisplayBooks();
        }
    }
}
