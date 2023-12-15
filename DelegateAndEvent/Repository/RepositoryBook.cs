using DelegateAndEvent.Models;


namespace DelegateAndEvent.Repository
{
    internal class RepositoryBook
    {
        private readonly List<Book> _books;

        public RepositoryBook()
        {
            _books = new List<Book>();
            _books.Add(new Book { Title = "Python", FullNameAuthor = "Donald Rich", CountPage = 90, Description = "adsgdfs" });
            _books.Add(new Book { Title = ".Net", FullNameAuthor = "Rich Martin", CountPage = 910, Description = "adsgdfs" });
        }

        internal void AddBook(Book book) 
        {
            _books.Add(book);
        }

        internal void UpdaterBook(Book book) 
        {
            _books.Find(b => b.Id == book.Id);
        }

        internal void DeleteBook(Book book) 
        {
            _books.Remove(book);
        }

        internal IEnumerable<Book> GetBooks() 
        {
            return _books;
        }
    }
}