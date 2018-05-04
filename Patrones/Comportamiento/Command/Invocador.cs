using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Command
{
    public class Invocador 
    {
        private ICommand comando;

        public Invocador(ICommand comando)
        {
            this.comando = comando;
        }

        public void run()
        {
            this.comando.execute();
        }
    }
}
