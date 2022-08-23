using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador pc = new Computador(2500,1000);
            Computador pc2 = new Computador(4000,800);
           

            Console.WriteLine(pc.ram+" "+pc.marca+" "+pc.disco+" "+pc.GetModelo());
            pc2.SetModelo("hpX turbo");
            Console.WriteLine(pc2.ram + " " + pc2.marca + " " + pc2.disco+" "+pc2.GetModelo());
            Console.ReadKey();

        }
    }
}
