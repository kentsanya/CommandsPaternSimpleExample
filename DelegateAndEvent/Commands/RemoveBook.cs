using DelegateAndEvent.Models;
using DelegateAndEvent.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.Commands
{
    internal class RemoveBook : IRepositoryCommand
    {
        private readonly RepositoryBook _books;
        private readonly Book _book;
        public RemoveBook(RepositoryBook repositoryBook, Book book) 
        {
            _books = repositoryBook;
            _book = book;
        }
        public void Execute()
        {
            _books.DeleteBook(_book);
        }

        public void Undo()
        {
            _books.AddBook(_book);
        }
    }
}
