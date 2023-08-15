using ConsoleAppSortBooks.entities;
using System.Collections.Generic;

namespace ConsoleAppSortBooks.managers
{
    public interface OrdenacaoLivros
    {
        List<Book> SortByTitle(List<Book> books);
        List<Book> SortByDate(List<Book> books);
        List<Book> SortByAuthor(List<Book> books);
        void printBooksList(List<Book> books);
        void printBooksOrder(List<Book> books);
        List<Book> SortByAuthorTitle(List<Book> books);
        List<Book> SortByEditionAuthorTitle(List<Book> books);
    }
}
