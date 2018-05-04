using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Command
{
    public class PrendeServer : ICommand
    {
        private IServer servidor;

        public PrendeServer(IServer servidor)
        {
            this.servidor = servidor;
        }

        public void execute()
        {
            servidor.conectate();
            servidor.verificaConexion();
            servidor.prendete();
            servidor.guardaLog();
            servidor.cerraConexion();
        }
    }
}
