using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Comportamiento.Memento
{
    public class Caretaker
    {
        private List<Memento> estados = new List<Memento>();

        public void addMemento(Memento m)
        {
            estados.Add(m);
        }

        public Memento getMemento(int index)
        {
            return estados[index];
        }
    }
}
