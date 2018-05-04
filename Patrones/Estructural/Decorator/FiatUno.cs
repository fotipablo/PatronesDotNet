using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Decorator
{
    public class FiatUno : Auto
    {
        public override string getDescripcion()
        {
            return "Fiat UNO 2015";
        }

        public override int getPrecio()
        {
            return 200000;
        }
    }
}
