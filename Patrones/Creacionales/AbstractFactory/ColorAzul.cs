﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creacionales.AbstractFactory
{
    public class ColorAzul : Color
    {
        public override void colorea(TV tv)
        {
            Console.WriteLine("Pintando de azul el " + tv.descripcion);
        }

        public bool EsPrimario { get; set; }
    }
}
