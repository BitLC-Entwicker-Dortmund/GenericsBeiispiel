using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsBeiispiel {
    class Program {
        static void Main ( string [ ] args ) {
            GenerischerContainer<string> gc = new GenerischerContainer<string> ( );
            gc.Element = "robert";
            gc.Einfuegen ( "4711-String" );

            GenerischerContainer<int> gcint = new GenerischerContainer<int> ( );
            gcint.Element = 67;
            gcint.Einfuegen ( 4711 );
        }
    }
}
