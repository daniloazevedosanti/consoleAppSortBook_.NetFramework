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
                Console.Write("Edição (yyyy): ");
                string dataLancamento = Console.ReadLine();

                Book book = new Book()
                {
                    Order = books.Count+1,
                    Title = titulo,
                    Author = autor,
                    Edition = dataLancamento
                };

                books.Add(book);

                Console.WriteLine(books.Count + " Livro(s) adicionado a lista.");
                Console.WriteLine("Deseja continuar a inserção? S / s - Sim e N / n - Não");
                string op2 = Console.ReadLine();
                if (op2.ToUpper().Equals("N"))
                    option = true;
            }

            Console.WriteLine(books.Count + " Livro(s) adicionado(s) abaixo.");
            OrdenacaoLivros managerSort = new SortBooks();
            managerSort.printBooksList(books);
            //foreach (Book item in books)
            //{ 
            //    Console.WriteLine(item.ToString());
            //}
            option = false;
            Console.Clear();
            while (!option)
            {

                Console.WriteLine("Escolha uma opção abaixo para ordenar (para 2 opções ou mais combine os números ex: 14) : ");
                Console.WriteLine("1 - Título ascendente  ");
                Console.WriteLine("2 - Autor ascendente, Título descendente  ");
                Console.WriteLine("3 - Data de Lançamento ascendente ");
                Console.WriteLine("4 - Edição descendente, Autor descendente, Título ascendente ");
                var num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        var orderBooksTitle = managerSort.SortByTitle(books);
                        managerSort.printBooksOrder(orderBooksTitle);
                        break;

                    case 2:
                        var orderBooksAuthor = managerSort.SortByAuthorTitle(books);
                        managerSort.printBooksOrder(orderBooksAuthor);
                        break;

                    case 3:
                        var orderBooksDate = managerSort.SortByDate(books);
                        managerSort.printBooksOrder(orderBooksDate);
                        break;

                    case 4:
                        var orderBooks = managerSort.SortByEditionAuthorTitle(books);
                        managerSort.printBooksOrder(orderBooks);
                        break;

                    default:
                        Console.WriteLine( new OrdenacaoException("Opcão nula ou inválida"));
                        break;
                }

                Console.WriteLine("Deseja ver outro modo de ordenação? S/s - Sim e N/n - Não");
                string op2 = Console.ReadLine();
                if (op2.ToUpper().Equals("N"))
                    option = true;

                Console.WriteLine(books.Count + " Livro(s) adicionado(s) abaixo.");
                managerSort.printBooksList(books);
                Console.Clear();
            }
        }
    }
}
