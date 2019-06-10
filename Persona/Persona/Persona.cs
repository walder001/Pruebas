using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
	public class Persona
	{
		public Persona()
		{
		   nombre ="Walder";
		   apellido = "Reyes";

		}
		public Persona(string nombre, string apellido)
		{
			this.nombre = nombre;
			this.apellido = apellido;

		}
		public string nombre { set; get; }
		public string apellido { set; get; }
		public int edad { set; get; }
		public char sexo { set; get; }

	}

}
