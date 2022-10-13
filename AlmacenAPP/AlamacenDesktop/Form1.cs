using Negocio;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlamacenDesktop
{
    public partial class Form1 : Form
    {
        CategoriaBL categoria = new CategoriaBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.codigo = int.Parse(txtCodigo.Text);
            cat.nombre= txtNombre.Text;
            categoria.createCategoria(cat);
        }
    }
}
