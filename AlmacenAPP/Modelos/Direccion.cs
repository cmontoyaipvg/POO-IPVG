using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Direccion
    {
        public int codigo { get; set; }
        public string calle { get; set; }
        public string region { get; set; }
        public int numero { get; set; }
        public string ciudad { get; set; }

        public Direccion()
        {

        }

        public Direccion(int codigo,string calle, string region, int numero, string ciudad)
        {
            this.codigo = codigo;
            this.calle = calle;
            this.region = region;
            this.numero = numero;
            this.ciudad = ciudad;
        }
    }
}
