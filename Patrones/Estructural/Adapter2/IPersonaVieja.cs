using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Adapter2
{
    public interface IPersonaVieja
    {
        String nombre { get; set; }
        String apellido { get; set; }
        DateTime fechaNacimiento { get; set; }
    }
}
