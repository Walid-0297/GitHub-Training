namespace LibrarySystemManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library system");

            Library library = new Library();

            Console.WriteLine("Are you Liberian or regular user ? (L/R)");

            var UserType = Console.ReadLine().ToUpper()[0]; // string is array of characters


            if (UserType == 'L')
            {
                Console.WriteLine("Enter your name : ");
                string LiberianName = Console.ReadLine();

                Liberian liberian1 = new Liberian(LiberianName); // Using Constractor

                Console.WriteLine($"Welcome {liberian1.Name} ");
                while (true)
                {
                    Console.WriteLine("Choose to add book (A) or remove book (B) or Display books (D)");
                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details : ");

                            Console.WriteLine("Name : ");
                            string BookName = Console.ReadLine();

                            Console.WriteLine("Author : ");
                            string Author = Console.ReadLine();

                            Console.WriteLine("Year : ");
                            int Year = Convert.ToInt32(Console.ReadLine());

                            Books books = new Books() // Using object initializers
                            {
                                Title = BookName,
                                Author = Author,
                                Year = Year
                            };
                            library.AddBooks(books, library);
                            break;

                        case 'R':
                            Console.WriteLine("Enter book details : ");

                            Console.WriteLine("Name : ");
                            BookName = Console.ReadLine();

                            Console.WriteLine("Author : ");
                            Author = Console.ReadLine();

                            Console.WriteLine("Year : ");
                            Year = Convert.ToInt32(Console.ReadLine());

                            books = new Books() // Using object initializers
                            {
                                Title = BookName,
                                Author = Author,
                                Year = Year
                            };
                            library.RemoveBooks(books, library);
                            break;

                        case 'd':
                            Console.WriteLine("The book list :");
                            library.DisplayBooks();
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else if (UserType == 'R')
            {
                Console.WriteLine("Enter your name : ");
                string name = Console.ReadLine();

                LibraryUser User = new LibraryUser(name); // Using Constractor

                Console.WriteLine($"Welcome {User.Name} ");

                while (true)
                {
                    Console.WriteLine("Choose to Display books (D) or borrow book (B)");
                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'd':
                            Console.WriteLine("The book list :");
                            library.DisplayBooks();
                            break;

                        case 'B':
                            Console.WriteLine("Enter book details to borrow : ");

                            Console.WriteLine("Name : ");
                            string BookName = Console.ReadLine();

                            Console.WriteLine("Author : ");
                            string Author = Console.ReadLine();

                            Console.WriteLine("Year : ");
                            int Year = Convert.ToInt32(Console.ReadLine());

                            Books books = new Books() // Using object initializers
                            {
                                Title = BookName,
                                Author = Author,
                                Year = Year
                            };
                            User.BorrowBooks(books, library);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter valid value , (L or R)");
            }
        }

    }
}
    

