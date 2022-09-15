using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicoBL
{
    internal interface ICrud
    {
        List<object> listar(); 
        object buscar(int id);
        void eliminar(object o);
        void actualizar(object o);
        void guardar(object o);
    }
}
