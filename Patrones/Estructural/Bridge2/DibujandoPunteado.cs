using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Bridge2
{
    public class DibujandoPunteado : Dibujo
    {
        public override void dibujaCirculo(int x, int y, int r)
        {
            Console.WriteLine("Dibujando un círculo punteado...");
        }

        public override void dibujaRectangulo(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Dibujando un rectángulo punteado...");
        }
    }
}
