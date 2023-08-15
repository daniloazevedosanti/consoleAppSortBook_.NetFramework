using ConsoleAppSortBooks.entities;
using ConsoleAppSortBooks.managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool option = false;
            List<Book> books = new List<Book>();

            while (!option)
            {
                Console.WriteLine("Insira dados do livro;");
                Console.Write("Titulo: "); 
                string titulo = Console.ReadLine();
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                Console.Write("Data Lançamento (dd-MM-yyyy): ");
                string dataLancamento = Console.ReadLine();

                Book book = new Book()
                {
                    Title = titulo,
                    Author = autor,
                    ReleaseDate = DateTime.Parse(dataLancamento)
                };

                books.Add(book);

                Console.WriteLine(books.Count + " Livro(s) adicionado a lista.");
                Console.WriteLine("Deseja continuar a inserção? S / s - Sim e N / n - Não");
                string op2 = Console.ReadLine();
                if (op2.ToUpper().Equals("N"))
                    option = true;
            }

            Console.WriteLine(books.Count + " Livro(s) adicionado(s) abaixo.");
            var managerSort = new SortBooks();
            managerSort.printBooksList(books);
            //foreach (Book item in books)
            //{ 
            //    Console.WriteLine(item.ToString());
            //}
            option = false;
            while (!option)
            {

                Console.WriteLine("Escolha uma opção abaixo para ordenar: ");
                Console.WriteLine("1 - Por Titulo  ");
                Console.WriteLine("2 - Por Autor  ");
                Console.WriteLine("3 - Por Data de Lançamento  ");
                var num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        var orderBooksTitle = managerSort.SortByTitle(books);
                        managerSort.printBooksList(orderBooksTitle);
                        break;

                    case 2:
                        var orderBooksAuthor = managerSort.SortByTitle(books);
                        managerSort.printBooksList(orderBooksAuthor);
                        break;

                    case 3:
                        var orderBooksDate = managerSort.SortByDate(books);
                        managerSort.printBooksList(orderBooksDate);
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Deseja ver outro modo de ordenação? S/s - Sim e N/n - Não");
                string op2 = Console.ReadLine();
                if (op2.ToUpper().Equals("N"))
                    option = true;
            }
        }
    }
}
