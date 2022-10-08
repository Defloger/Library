using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _222
{
    internal class Book
    {
        private string _nameAuthor;
        private int _countPage;
        private string _bookName;
        private int _date;

        public Book(string nameAuthor, int countPage, string bookName, int data)
        {
            _nameAuthor = nameAuthor;
            _countPage = countPage;
            _bookName = bookName;
            _date = data;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Автор книги - {_nameAuthor}");
            Console.WriteLine($"Количество страниц - {_countPage}");
            Console.WriteLine($"Название книги - {_bookName}");
            Console.WriteLine($"Год выпуска - {_date}");
            Console.WriteLine();
        }
    }
}

