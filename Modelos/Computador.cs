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
        public int disco;
        public string marca;
        private int precio;

        public Computador(int cantidadRam, int cantidadDisco)
        {
            ram = cantidadRam;
            marca = "HP";
            cpu = "I7 89788";
            disco = cantidadDisco;
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
