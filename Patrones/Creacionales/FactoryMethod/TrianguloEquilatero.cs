using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.FactoryMethod
{
    
    public class TrianguloEquilatero : Triangulo
    {

        public TrianguloEquilatero(int anguloA, int anguloB, int anguloC) : base(anguloA, anguloB, anguloC) {}

        public override String getDescripcion()
        {
            return "Soy un Triangulo Equilatero";
        }

        public override double getSuperficie()
        {
            // Algoritmo para calcular superficie
            return 0;
        }

        public override void dibujate()
        {
            // Algoritmo para dibujarse                
        }

    }
}
