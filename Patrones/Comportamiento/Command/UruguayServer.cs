using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Command
{  
    public class UruguayServer : IServer
    {
        public void apagate()
        {
            Console.WriteLine("Apagando el servidor de Uruguay");
        }

        public void cerraConexion()
        {
            Console.WriteLine("Cerrando conexión con el servidor de Uruguay");
        }

        public void conectate()
        {
            Console.WriteLine("Conectando con el servidor de Uruguay");
        }

        public void guardaLog()
        {
            Console.WriteLine("Guardando log del servidor de Uruguay");
        }

        public void prendete()
        {
            Console.WriteLine("Prendiendo servidor de Uruguay");
        }

        public void verificaConexion()
        {
            Console.WriteLine("Comprobando conexión al servidor de Uruguay");
        }
    }
}
