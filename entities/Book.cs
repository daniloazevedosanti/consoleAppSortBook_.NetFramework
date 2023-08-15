using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortBooks.entities
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }

        public override string ToString()
        {
            return "Titulo: " + Title.ToString() + " Autor: " + Author.ToString() + " Lançamento: " + ReleaseDate.ToString();
        }
    }
}
