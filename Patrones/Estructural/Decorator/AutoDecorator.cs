using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Decorator
{
    public abstract class AutoDecorator : IVendible
    {
        public AutoDecorator(IVendible vendible)
        {
            this.vendible = vendible;
        }

        public IVendible vendible { get; set; }

        public abstract string getDescripcion();
        public abstract int getPrecio();
    }
}
