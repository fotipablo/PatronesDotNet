using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.ChainOfResponsability
{
    public class Gerente : IAprobador
    {

        private IAprobador next;

        public IAprobador getNext()
        {
            return next;
        }

        public void solicitudPrestamo(int monto)
        {
            if (monto > 50000 && monto <= 100000)
            {
                Console.WriteLine("Lo manejo yo, el gerente");
            }
            else
            {
                next.solicitudPrestamo(monto);
            }

        }

        public void setNext(IAprobador aprobador)
        {
            next = aprobador;
        }

    }
}
