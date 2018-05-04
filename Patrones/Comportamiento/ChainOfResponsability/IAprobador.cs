using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.ChainOfResponsability
{
    public interface IAprobador
    {

        void setNext(IAprobador aprobador);
        IAprobador getNext();
        void solicitudPrestamo(int monto);

    }
}
