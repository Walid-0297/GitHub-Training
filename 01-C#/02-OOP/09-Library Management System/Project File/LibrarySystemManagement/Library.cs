using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibrarySystemManagement
{
    internal class Library
    {
        // Encapsulation 
        // these fiedls the user can't access or modify it 

        private Books[] Books = new Books[100];
        private int NumberOfCurrentBooks = 0;

        private Books[] BorrowedBooks = new Books[50];
        private int NumberOfBorrowedBooks = 0;

        public void DisplayBooks()
        {
            for (int i = 0; i < NumberOfCurrentBooks; i++)
            {
                Console.WriteLine(Books[i]);
            }

        }
        public void AddBooks(Books book, Library library)
        {
            if (NumberOfCurrentBooks < Books.Length)
            {
                Books[NumberOfCurrentBooks] = book;
                NumberOfCurrentBooks++;
                Console.WriteLine("new Book Added Successfully");
            }
            else
            {
                Console.WriteLine("The library is full");
            }

        }
        public void RemoveBooks(Books book, Library library)
        {
            int index = Array.IndexOf(Books, book);
            Books[index] = null;
            NumberOfCurrentBooks--;
            Console.WriteLine("new Book removed Successfully");
        }
        public void BoroowBook(Books book)
        {
            if (NumberOfBorrowedBooks < BorrowedBooks.Length)
            {
                BorrowedBooks[NumberOfBorrowedBooks] = book;
                NumberOfCurrentBooks++;
                Console.WriteLine("new Book borrowed Successfully");
            }
            else
            {
                Console.WriteLine("Can't borrow more");
            }
        }
    
    } 
}
