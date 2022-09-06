using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico
{
    public class Proveedor
    {
        public string rut { get; set; }
        public string razonSocial { get; set; }
        public int giro { get; set; }
        public List<Direccion> direciones { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public List<Vendedor> vendedores { get; set; }

        public Proveedor()
        {
            direciones = new List<Direccion>();
            vendedores = new List<Vendedor>();
        }

        public void AsignarDireccion(Direccion direccion) {
            direciones.Add(direccion);
        }

        public void AsignarVendedor(Vendedor vendedor)
        {
            vendedores.Add(vendedor);
        }
    }
}
