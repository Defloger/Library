using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _222
{
    internal class Library
    {
        private Book[] _books = new Book[0];
        public void ListOfBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book);
            }
        }

        public void DeleteBook()
        {

        }

        public void AddBook(Book book)
        {



            if (_books.Length == 0)
            {
                _books = new Book[] { book };

            }

            else if (_books.Length > 0)
            {
                Book[] books2 = new Book[_books.Length + 1];


                _books = books2;

            }
        }
    }
}
