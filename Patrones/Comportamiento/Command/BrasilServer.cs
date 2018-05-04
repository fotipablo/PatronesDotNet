using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Command
{
    public class BrasilServer : IServer
    {
        public void apagate()
        {
            Console.WriteLine("Apagando el servidor de Brasil");
        }

        public void cerraConexion()
        {
            Console.WriteLine("Cerrando conexión con el servidor de Brasil");
        }

        public void conectate()
        {
            Console.WriteLine("Conectando con el servidor de Brasil");
        }

        public void guardaLog()
        {
            Console.WriteLine("Guardando log del servidor de Brasil");
        }

        public void prendete()
        {
            Console.WriteLine("Prendiendo servidor de Brasil");
        }

        public void verificaConexion()
        {
            Console.WriteLine("Comprobando conexión al servidor de Brasil");
        }
    }
}
