using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.ChainOfResponsability
{
    public class LiderTeamEjecutivo : IAprobador
    {
        private IAprobador next;

        public IAprobador getNext()
        {
            return next;
        }

        public void solicitudPrestamo(int monto)
        {
            if (monto > 10000 && monto <= 50000)
            {
                Console.WriteLine("Lo manejo yo, el lider");
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
