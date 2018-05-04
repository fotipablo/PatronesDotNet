﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.ChainOfResponsability
{
    public class Director : IAprobador
    {
        private IAprobador next;

        public IAprobador getNext()
        {
            return next;
        }

        public void solicitudPrestamo(int monto)
        {
            if (monto >= 100000)
            {
                Console.WriteLine("Lo manejo yo, el director");
            }
        }

        public void setNext(IAprobador aprobador)
        {
            next = aprobador;
        }

    }
}
