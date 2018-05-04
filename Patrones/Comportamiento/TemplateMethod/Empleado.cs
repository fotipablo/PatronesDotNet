using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.TemplateMethod
{
    public class Empleado : Persona
    {     
        private String legajo;

        public Empleado(String legajo)
        {
            this.legajo = legajo;
        }

        protected override string getIdentificacion()
        {
            return this.legajo;
        }

        protected override string getTipoId()
        {
            return "Número de legajo";
        }

    }
}
