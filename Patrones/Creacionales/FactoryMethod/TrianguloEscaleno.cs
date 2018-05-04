﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.FactoryMethod
{

    public class TrianguloEscaleno : Triangulo
    {
        public TrianguloEscaleno(int ladoA, int ladoB, int ladoC) : base(ladoA, ladoB, ladoC){ }

        public override String getDescripcion()
        {
            return "Soy un Triangulo Escaleno";
        }

        public override double getSuperficie()
        {
            return 0;
        }

        public override void dibujate()
        {
            // Algoritmo para dibujarse
        }

    }
}
