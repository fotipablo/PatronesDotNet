using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Command
{
    public class ArgentinaServer : IServer
    {
        public void apagate()
        {
            Console.WriteLine("Apagando el servidor de Argentina");
        }

        public void cerraConexion()
        {
            Console.WriteLine("Cerrando conexión con el servidor de Argentina");
        }

        public void conectate()
        {
            Console.WriteLine("Conectando con el servidor de Argentina");
        }

        public void guardaLog()
        {
            Console.WriteLine("Guardando log del servidor de Argentina");
        }

        public void prendete()
        {
            Console.WriteLine("Prendiendo servidor de Argentina");
        }

        public void verificaConexion()
        {
            Console.WriteLine("Comprobando conexión al servidor de Argentina");
        }
    }
}
