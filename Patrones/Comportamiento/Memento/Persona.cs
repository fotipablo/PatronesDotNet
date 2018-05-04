using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Memento
{
    public class Persona
    {
        public String nombre { get; set; }

        public Memento saveToMemento()
        {
            Console.WriteLine("Originator: Guardando memento...");
            return new Memento(this.nombre);
        }

        public void restoreFromMemento(Memento m)
        {
            this.nombre = m.getSavedState();
        }

    }
}
