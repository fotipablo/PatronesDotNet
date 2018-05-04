using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.TemplateMethod
{
    public class Cliente : Persona
    {
        private int numeroCliente;

        public Cliente(int numCliente)
        {
            this.numeroCliente = numCliente;
        }

        protected override string getIdentificacion()
        {
            return this.numeroCliente.ToString();
        }

        protected override string getTipoId()
        {
            return "Número de cliente";
        }
        
    }
}
