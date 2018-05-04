using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Visitor
{
    public class IVA : IVisitor
    {
        private const double impuestoNormal = 1.21;
        private const double impuestoReducido = 1.105;

        public double visitar(ProductoDescuento producto)
        {
            return producto.precio * impuestoReducido;
        }

        public double visitar(ProductoNormal producto)
        {
            return producto.precio * impuestoNormal;
        }
    }
}
