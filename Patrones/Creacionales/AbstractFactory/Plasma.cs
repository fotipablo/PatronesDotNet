using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.AbstractFactory
{
    public class Plasma : TV
    {
        public Plasma() : base()
        {
            this.descripcion = "Plasma.. próximamente será un LED";
        }

        public Plasma(string marca, int pulgadas, string color, string descripcion, double precio, double anguloVision, double tiempoRespuesta) 
            : base(marca, pulgadas, color, descripcion, precio)
        {
            this.anguloVision = anguloVision;
            this.tiempoRespuesta = tiempoRespuesta;
        }

        public double anguloVision { get; set; }
        public double tiempoRespuesta { get; set; }
    }
}
