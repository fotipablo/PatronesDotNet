using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.AbstractFactory
{
    public abstract class TvAbstractFactory
    {
        public abstract TV createTV();
        public abstract Color createColor();
    }
}
