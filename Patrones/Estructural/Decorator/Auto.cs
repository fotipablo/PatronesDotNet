using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Decorator
{
    public abstract class Auto : IVendible
    {
        public abstract string getDescripcion();
        public abstract int getPrecio();
    }
}
