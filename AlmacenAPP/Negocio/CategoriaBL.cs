
using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class CategoriaBL
    {

        public Data data { get; set; }

        public CategoriaBL()
        {
            data = new Data();
        }
        public List<Categoria> getCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            DataTable dt = data.listarData("select * from categoria");

            foreach (DataRow item in dt.Rows)
            {
                Categoria ca = new Categoria();
                ca.codigo = int.Parse(item[0].ToString());
                ca.nombre = item.ItemArray[1].ToString(); ;
                categorias.Add(ca);
                //sddfsdfsdfsdf
            }
           

            return categorias;
        }

        public void createCategoria(Categoria categoria)
        { 
           
        }
    }
}