using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Bridge2
{
    public abstract class Dibujo
    {
        public abstract void dibujaRectangulo(int x1, int y1, int x2, int y2);
        public abstract void dibujaCirculo(int x, int y, int r);
    }
}
