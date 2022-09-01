using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class Notebook:Computador
    {
        public string bateria;
        public Disco d1;
        public Notebook()
        {
            this.
            d1 = new Disco();
            d1.capacidad = 15;
        }
    }
}
