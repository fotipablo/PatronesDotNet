using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.InyeccionDependencia
{
    public class Robot
    {
        public Robot() { }

        #region Métodos

        public void Caminar()
        {
            if (Cuerpo != null)
                Cuerpo.Caminar();
        }

        public void Volar()
        {
            if (Cuerpo != null)
                Cuerpo.Volar();
        }

        public void Disparar()
        {
            if (Cuerpo != null)
                Cuerpo.Disparar();
        }

        /*Hacer otras cosas cool que hacen los robots*/
        public void BuscarAJhonConnor()
        {
            /*Paso 1 buscar en internet
            *Paso 2 Cuerpo.Caminar();
            *Paso 3 Cuerpo.Disparar();
            *Paso N*/
        }

        #endregion

        #region Propiedades

        public Cuerpo Cuerpo { get; set; }

        #endregion
    }
}
