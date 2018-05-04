using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.FactoryMethod
{
    public interface ITrianguloFactoryMethod
    {
        Triangulo createTriangulo(int ladoA, int ladoB, int ladoC);
    }
}
