using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.AbstractFactory
{
    public class TV
    {
        public String marca { get; set; }
        public int pulgadas { get; set; }
        public String color { get; set; }
        public String descripcion { get; set; }
        public double precio { get; set; }

        public TV() { }

        public TV(String marca, int pulgadas, String color, String descripcion, double precio)
        {
            this.marca = marca;
            this.pulgadas = pulgadas;
            this.color = color;
            this.descripcion = descripcion;
            this.precio = precio;
        }

    }
}
