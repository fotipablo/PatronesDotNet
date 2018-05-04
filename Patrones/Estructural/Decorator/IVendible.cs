using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Decorator
{
    public interface IVendible
    {
        String getDescripcion();
        int getPrecio();
    }
}
