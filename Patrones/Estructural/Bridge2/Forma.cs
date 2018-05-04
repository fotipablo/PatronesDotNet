using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Bridge2
{
    public abstract class Forma
    {
        private Dibujo dibujo;

        public Forma(Dibujo d)
        {
            this.dibujo = d;
        }

        public Dibujo Dibujo
        {
            get
            {
                return this.dibujo;
            }

            set
            {
                this.dibujo = value;
            }
        }

        public abstract void dibuja();

        public void dibujaRectanculo(int x1, int y1, int x2, int y2)
        {
            this.dibujo.dibujaRectangulo(x1, y1, x2, y2);
        }

        public void dibujaCirculo(int x, int y, int r)
        {
            this.dibujo.dibujaCirculo(x, y, r);
        }

    }
}
