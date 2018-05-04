using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.AbstractFactory
{
    public abstract class Color
    {
        public String descripcion { get; set; }

        public abstract void colorea(TV tv);

    }
}
