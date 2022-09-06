using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico
{
    public class Direccion
    {
        public string calle { get; set; }
        public string region { get; set; }
        public int numero { get; set; }
        public string ciudad { get; set; }

        public Direccion()
        {

        }

        public Direccion(string calle, string region, int numero, string ciudad)
        {
            this.calle = calle;
            this.region = region;
            this.numero = numero;
            this.ciudad = ciudad;
        }
    }
}
