using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.FactoryMethod
{
    public class TrianguloFactory : ITrianguloFactoryMethod
    {
        public Triangulo createTriangulo(int ladoA, int ladoB, int ladoC)
        {
            if ((ladoA == ladoB) && (ladoA == ladoC))
            {
                return new TrianguloEquilatero(ladoA, ladoB, ladoC);
            }
            else if ((ladoA != ladoB) && (ladoA != ladoC) && (ladoB != ladoC))
            {
                return new TrianguloEscaleno(ladoA, ladoB, ladoC);
            }
            else
            {
                return new TrianguloIsosceles(ladoA, ladoB, ladoC);
            }

        }

    }
}
