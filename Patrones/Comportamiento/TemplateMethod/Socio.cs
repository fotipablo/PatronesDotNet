using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.TemplateMethod
{
    public class Socio : Persona
    {
        public Socio(int numSocio)
        {
            this.numeroSocio = numSocio;
        }

        private int numeroSocio;

        protected override string getIdentificacion()
        {
            return this.numeroSocio.ToString();
        }

        protected override string getTipoId()
        {
            return "número de socio";
        }
    }
}
