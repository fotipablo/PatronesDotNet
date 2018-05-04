using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Command2
{
    public interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
