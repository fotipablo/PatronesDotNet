using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.AbstractFactory
{
    public class EnsamblajeTV
    {
        public EnsamblajeTV(TvAbstractFactory fab)
        {
            Color color = fab.createColor();
            TV tv = fab.createTV();

            color.colorea(tv);
        }
    }
}
