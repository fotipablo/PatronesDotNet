using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Decorator
{
    public class CierreCentralizado : AutoDecorator
    {
        public CierreCentralizado(IVendible vendible) : base(vendible) { }

        public override string getDescripcion()
        {
            return this.vendible.getDescripcion() + " Cierre centralizado";
        }

        public override int getPrecio()
        {
            return this.vendible.getPrecio() + 2000;
        }
    }
}
