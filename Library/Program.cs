using System;

namespace Library
{
    class Program
    {
        public static Library<Book> Library { get; set; }
        public static Library<Book> Library { get; set; }

        static void Main(string[] args)
        {
            Library = new Library<Book>();
            BookBag = new Library<Book>();

            Console.WriteLine("Welcome to Dolly Parton's Imagination Library");
            Console.WriteLine("Enter the letter for the command you need");
            string input = Console.ReadLine();

            if (input == "L") ;
            LoadBooks();
        }

        public static void AddABook(string title, string firstName, string lastName, int numberOfPages, Genre genre)
        {
            Book book = new Book()
            {
                Title = title,
                Author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName
                },
                NumberOfPages = numberOfPages,
                Genre = genre
            };

            Library.Add(book);
        }

    }
}
}
