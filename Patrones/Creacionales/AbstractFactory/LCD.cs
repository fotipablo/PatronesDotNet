using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.AbstractFactory
{
    public class LCD : TV
    {
        public LCD(): base()
        {
            this.descripcion = "LCD";
        }

        public LCD(string marca, int pulgadas, string color, string descripcion, double precio) 
            : base(marca, pulgadas, color, descripcion, precio)
        {
        }

        public double costoFabricacion { get; set; }


    }
}
