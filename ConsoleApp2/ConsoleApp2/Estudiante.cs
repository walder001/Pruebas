using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Estudiante :Persona
	{
		public string Matricula { get; set; }
		public DateTime FechaIngreso { get; set; }
		public string Carrera { get; set; }
		public override string NombreCompleto
		{
			get
			{
				return string.Format("{0} {1} {2}", Matricula, Nombre, Apellido);
			}
		}

	}
}
