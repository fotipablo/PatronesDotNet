using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Command
{
    public interface IServer
    {
        void apagate();
        void prendete();
        void conectate();
        void verificaConexion();
        void guardaLog();
        void cerraConexion();
    }
}
