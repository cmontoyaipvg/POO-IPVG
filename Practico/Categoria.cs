using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico
{
    public class Categoria
    {
        public int codigo { get; set; }
        public string nombre { get; set; }

        public Categoria()
        {
                
        }

        public Categoria(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}
