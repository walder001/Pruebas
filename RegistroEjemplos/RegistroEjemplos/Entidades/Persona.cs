using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroEjemplos.Entidades
{
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Cedula { get; set; }
        public String Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona()
        {
            PersonaId = 0;
            Nombre = String.Empty;
            Telefono = String.Empty;
            Cedula = String.Empty;
            Direccion = String.Empty;
            FechaNacimiento = DateTime.Now;
        }
    }
}
