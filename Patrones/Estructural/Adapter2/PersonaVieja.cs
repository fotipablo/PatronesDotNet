using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Adapter2
{
    public class PersonaVieja : IPersonaVieja
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
