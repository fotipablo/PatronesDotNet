using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.AbstractFactory
{
    public class FactoryPlasmaAmarillo : TvAbstractFactory
    {
        public override Color createColor()
        {
            return new ColorAmarillo();
        }

        public override TV createTV()
        {
            return new Plasma();
        }
    }
}
