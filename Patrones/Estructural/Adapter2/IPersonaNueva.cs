using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Adapter2
{
    public interface IPersonaNueva
    {
        String nombre { get; set; }
        int edad { get; set; }
    }
}
