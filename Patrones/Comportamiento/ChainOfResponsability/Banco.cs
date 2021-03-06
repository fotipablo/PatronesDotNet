﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.ChainOfResponsability
{
    public class Banco : IAprobador
    {

        private IAprobador next;

        public IAprobador getNext()
        {
            return next;
        }

        public void solicitudPrestamo(int monto)
        {
            EjecutivoDeCuenta ejecutivo = new EjecutivoDeCuenta();

            this.setNext(ejecutivo);

            LiderTeamEjecutivo lider = new LiderTeamEjecutivo();

            ejecutivo.setNext(lider);

            Gerente gerente = new Gerente();

            lider.setNext(gerente);


            Director director = new Director();

            gerente.setNext(director);


            next.solicitudPrestamo(monto);

        }

        public void setNext(IAprobador aprobador)
        {
            next = aprobador;
        }

    }
}
