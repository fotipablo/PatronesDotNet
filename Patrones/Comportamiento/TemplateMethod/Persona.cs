using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.TemplateMethod
{
    public abstract class Persona
    {
        private String nombre;
        private String dni;

        public String identificate()
        {
            String frase = "Me identifico con: ";
            frase += getTipoId();
            frase += ". el número es";
            frase += getIdentificacion();
            return frase;
        }

        protected abstract String getIdentificacion();
        protected abstract String getTipoId();
    }
}
