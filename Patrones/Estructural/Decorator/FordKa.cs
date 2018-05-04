using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Decorator
{
    public class FordKa : Auto
    {
        public override string getDescripcion()
        {
            return "Ford Ka 2016";
        }

        public override int getPrecio()
        {
            return 210000;
        }
    }
}
