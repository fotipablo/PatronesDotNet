using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Command
{

    public class ResetServer : ICommand
    {
        private IServer servidor;

        public ResetServer(IServer servidor)
        {
            this.servidor = servidor;
        }

        public void execute()
        {
            servidor.conectate();
            servidor.verificaConexion();
            servidor.guardaLog();
            servidor.apagate();
            servidor.prendete();
            servidor.guardaLog();
            servidor.cerraConexion();
        }
    }
}
