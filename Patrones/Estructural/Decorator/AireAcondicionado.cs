using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Decorator
{
    public class AireAcondicionado : AutoDecorator
    {
        public AireAcondicionado(IVendible vendible) : base(vendible) { }

        public override string getDescripcion()
        {
            return this.vendible.getDescripcion() + " Aire acondicionado";
        }

        public override int getPrecio()
        {
            return this.vendible.getPrecio() + 1000;
        }
    }
}
