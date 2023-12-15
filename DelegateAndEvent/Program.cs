using DelegateAndEvent.Commands;
using DelegateAndEvent.Models;
using DelegateAndEvent.Repository;

namespace DelegateAndEvent
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            //Lisener commands
            InvokerComandRepository invokerComandRepository = new InvokerComandRepository();

            //init data
            //example database
            RepositoryBook repositoryBook = new RepositoryBook();
            //input book
            //example html form
            Book book = new Book() { Title = "Java", CountPage = 900 };

            //створення команд черех інтерфейс, без привязки до конкретики
            IRepositoryCommand addcomand = new AddBook(repositoryBook, book);
            IRepositoryCommand removecomand = new RemoveBook(repositoryBook, book);


            //using example
            invokerComandRepository.SetCommand(removecomand);
            invokerComandRepository.Exute();

            invokerComandRepository.Undo();




        }
    }
}