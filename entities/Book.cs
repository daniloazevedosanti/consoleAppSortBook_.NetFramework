﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortBooks.entities
{
    public class Book
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Edition { get; set; }

        public override string ToString()
        {
            return "Titulo: " + Title.ToString() + " Autor: " + Author.ToString() + " Edição: " + Edition.ToString();
        }
    }
}
