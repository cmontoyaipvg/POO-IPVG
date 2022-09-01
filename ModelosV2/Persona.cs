using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosV2
{
    public class Persona
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNac { get; set; }
        public Direccion direccion { get; set; }
        public List<Contacto> contacto { get; set; }

        public Persona()
        {
            this.contacto = new List<Contacto>();
        }

        public void AsignaDireccion(string calle,int numero, string region, string ciudad)
        {
            Direccion dir = new Direccion();
            dir.Calle=calle;
            dir.Numero=numero;  
            dir.Region=region;
            dir.Ciudad = ciudad;
            this.direccion = dir;            
        }

        public void AgregarContacto(Contacto contacto) {

            this.contacto.Add(contacto);
        }

        public string TelefonoContacto() {
            if (contacto.Count > 0)
            {
               return contacto.FirstOrDefault().Telefono;
            }
            else {
                return "0";
            }
        }
    }
}
