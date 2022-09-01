using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelosV2;
namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Computador pc = new Computador(2500,1000);
            //Computador pc2 = new Computador(4000,800);
            //Monitor 

            //Console.WriteLine(pc.ram+" "+pc.marca+" "+pc.disco+" "+pc.GetModelo());
            //pc2.SetModelo("hpX turbo");
            //Console.WriteLine(pc2.ram + " " + pc2.marca + " " + pc2.disco+" "+pc2.GetModelo());

            Persona p = new Persona();
            p.rut = "111-1";
            p.nombre = "Juan";

            Contacto contacto= new Contacto();
            contacto.Nombre = p.nombre;
            contacto.Telefono = "+56988888";
            contacto.Mail = "aaaa@ssss.cl";

            p.AgregarContacto(contacto);

            Console.WriteLine("Nombre:"+p.nombre+" Telefono:"+ p.TelefonoContacto());

            Console.ReadKey();

        }
    }
}
