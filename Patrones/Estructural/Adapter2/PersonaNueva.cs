using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Adapter2
{
    public class PersonaNueva : IPersonaNueva
    {
        public int edad { get; set; }
        public string nombre { get; set; }
    }
}
