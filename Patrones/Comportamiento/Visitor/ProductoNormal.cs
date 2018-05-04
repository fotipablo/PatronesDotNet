using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Visitor
{
    public class ProductoNormal : IVisitable
    {
        public double precio { get; set; }

        public double aceptar(IVisitor visitor)
        {
            return visitor.visitar(this);
        }
    }
}
