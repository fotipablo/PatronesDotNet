using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Memento
{
    public class Memento
    {
        private String estado;

        public Memento(String estado)
        {
            this.estado = estado;
        }

        public String getSavedState()
        {
            return this.estado;
        }
        
    }
}
