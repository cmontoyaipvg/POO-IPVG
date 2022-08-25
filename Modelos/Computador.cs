using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Computador
    {
        public string cpu;
        public int ram;
        private string modelo;
        public string marca;
        protected int precio;

        public Computador()
        {

        }
        public Computador(int cantidadRam, int cantidadDisco)
        {
            ram = cantidadRam;
            marca = "HP";
            cpu = "I7 89788";
            modelo = "Pavilion";
        }

        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string modelo) {
            this.modelo = modelo;
        }
    }

}
