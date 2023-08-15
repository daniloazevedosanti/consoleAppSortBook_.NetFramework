using ConsoleAppSortBooks.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortBooks.managers
{
    public class SortBooks : OrdenacaoLivros
    {
        
        public void printBooksOrder(List<Book> books)
        {
            Console.Write("Livros ");
            foreach (Book item in books)
            {
                Console.Write(" ");
                Console.Write(item.Order +",");
            }
            Console.ReadLine();
        }
        public void printBooksList(List<Book> books)
        {
            foreach (Book item in books)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
        public List<Book> SortByTitle(List<Book> books)
        {
            var booksByTitle =
               (from book in books
                orderby book.Title
                select book).ToList();

            return booksByTitle;
        }

        public List<Book> SortByDate(List<Book> books)
        {
            return books.OrderBy(date => date.ReleaseDate).ToList();
        }

        public List<Book> SortByAuthor(List<Book> books)
        {
            return books.OrderBy(a => a.Author).ToList();
        }
    }
}
