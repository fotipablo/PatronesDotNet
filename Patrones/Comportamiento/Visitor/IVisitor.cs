using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Visitor
{
    public interface IVisitor
    {
        double visitar(ProductoNormal producto);
        double visitar(ProductoDescuento producto);
    }
}
