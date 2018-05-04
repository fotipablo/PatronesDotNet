using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Bridge2
{
    public class Circulo : Forma
    {
        private int coordX, coordY, coorR;

        public Circulo(Dibujo d, int x, int y, int r) : base(d)
        {
            this.coordX = x;
            this.coordY = y;
            this.coorR = r;
        }

        public override void dibuja()
        {
            dibujaCirculo(coordX, coordY, coorR);
        }
    }
}
