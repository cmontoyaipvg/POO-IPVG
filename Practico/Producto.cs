using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico
{
    public class Producto
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public Categoria categoria { get; set; }
        public List<Proveedor> proveedores { get; set; }

        public Producto(Categoria categoria)
        {
            this.categoria = categoria;
            this.proveedores = new List<Proveedor>();
        }

        public void AsignaProveedor(Proveedor proveedor)
        {
            proveedores.Add(proveedor);
        }
        
    }
}
