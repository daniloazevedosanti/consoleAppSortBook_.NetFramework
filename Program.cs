using ConsoleAppSortBooks.entities;
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
                Console.WriteLine("Titulo:"); 
                string titulo = Console.ReadLine();
                Console.WriteLine("Autor:");
                string autor = Console.ReadLine();
                Console.WriteLine("Data Lançamento (dd-MM-yyyy):");
                string dataLancamento = Console.ReadLine();

                Book book = new Book() 
                { 
                
                };

            }
        }
    }
}
