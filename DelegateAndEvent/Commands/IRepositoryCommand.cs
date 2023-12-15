using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.Commands
{
    internal interface IRepositoryCommand
    {
        //Start command
        void Execute();

        //Backap command
        void Undo();
    }
}
