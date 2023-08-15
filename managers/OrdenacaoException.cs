using System;

namespace ConsoleAppSortBooks.managers
{
    public class OrdenacaoException : Exception
    {

        public OrdenacaoException()
        {

        }

        public OrdenacaoException(string message) 
            : base(message)
        {

        }
    }
}
