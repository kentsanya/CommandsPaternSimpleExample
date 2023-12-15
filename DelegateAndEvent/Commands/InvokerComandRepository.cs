using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.Commands
{
    internal class InvokerComandRepository 
    {
        private IRepositoryCommand _repositoryCommand;
        private Stack<IRepositoryCommand> _commandHistory =new Stack<IRepositoryCommand>();
        internal void SetCommand(IRepositoryCommand repositoryCommand)
        {
            _repositoryCommand=repositoryCommand;
        }

        internal void Exute() 
        {

            _repositoryCommand.Execute();
            _commandHistory.Push(_repositoryCommand);
        }

        internal void Undo()
        {
            if (_commandHistory.Any())
            {
                var previewcommand = _commandHistory.Pop();
                previewcommand.Undo();
            }
           
        }
    }
}
