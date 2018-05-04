using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Decorator
{
    public class CdPlayer : AutoDecorator
    {
        public CdPlayer(IVendible vendible) : base(vendible) { }

        public override string getDescripcion()
        {
            return this.vendible.getDescripcion() + " CD Player";
        }

        public override int getPrecio()
        {
            return this.vendible.getPrecio() + 250;
        }
    }
}
