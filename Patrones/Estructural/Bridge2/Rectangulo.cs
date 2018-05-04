using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Bridge2
{
    public class Rectangulo : Forma
    {
        private int coordX1, coordY1, coordX2, coordY2;

        public Rectangulo(Dibujo d, int x1, int y1, int x2, int y2) : base(d)
        {
            this.coordX1 = x1;
            this.coordY1 = y1;
            this.coordX2 = x2;
            this.coordY2 = y2;
        }

        public override void dibuja()
        {
            this.dibujaRectanculo(coordX1, coordY1, coordX2, coordY2);
        }
    }
}
