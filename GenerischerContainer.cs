using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsBeiispiel {
    class GenerischerContainer<T> {
        // Liste eines generischen Typs
        private List<T> meineListe = new List<T>();

        public T Element { get; set; }

        public void Einfuegen ( T element ) {
            meineListe.Add ( element );
        }
    }
}
