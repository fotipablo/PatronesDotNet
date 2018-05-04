using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Adapter2
{
    public class ViejaToNuevaAdapter : IPersonaNueva
    {
        private IPersonaVieja Vieja;

        public ViejaToNuevaAdapter(IPersonaVieja vieja)
        {
            this.Vieja = vieja;
        }

        public int edad
        {
            get
            {
                DateTime zeroTime = new DateTime(1, 1, 1);                

                TimeSpan diferencia = DateTime.Today - Vieja.fechaNacimiento;

                // because we start at year 1 for the Gregorian 
                // calendar, we must subtract a year here.
                return (zeroTime + diferencia).Year - 1;
            }

            set
            {
                int anioNacim = DateTime.Today.Year - value;
                this.Vieja.fechaNacimiento =
                    new DateTime(anioNacim, DateTime.Today.Month, DateTime.Today.Day);
            }
        }

        public string nombre
        {
            get
            {
                return string.Format("{0} {1}", this.Vieja.nombre, this.Vieja.apellido);
            }

            set
            {
                String[] nombres = value.Split(' ');
                this.Vieja.nombre = nombres[0];
                this.Vieja.apellido = nombres[1];

            }
        }
    }
}
