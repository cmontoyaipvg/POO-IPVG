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
            
               conexion = new SqlConnection("Data Source=PC19LAB318\\SQLEXPRESS;Initial Catalog=practico;User ID=sa;Password=ipvg2022");//Trusted_Connection=True
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

        public DataTable listarData(string query) {
            conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = query;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            desconectar();
            return ds.Tables[0];
        }      

    }
}
