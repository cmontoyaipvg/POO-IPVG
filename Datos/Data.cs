using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Practico;

namespace Datos
{
    public class Data
    {
        public SqlConnection conexion;

        public Data()
        {
            conexion = new SqlConnection("Data Source=PC31LAB108\\SQLEXPRESS;Initial Catalog=practico;User ID=sa;Password=ipvg2022");//Trusted_Connection=True
        }

        public void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void desconectar() {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public List<Categoria> getCategorias() { 
            List<Categoria> categorias = new List<Categoria>();

            SqlCommand cmd = new SqlCommand("Select * from categoria",conexion);
            conectar();
            SqlDataReader reader= cmd.ExecuteReader();
            while (reader.Read()) {
                Categoria item = new Categoria();
                item.codigo = reader.GetInt32(0);
                item.nombre = reader.GetString(1);
                categorias.Add(item);
            }
            desconectar();  

            return categorias;
        }

    }
}
