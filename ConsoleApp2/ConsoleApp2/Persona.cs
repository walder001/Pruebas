using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Persona
	{
		public string Nombre { set; get; }
		public string Apellido { set; get; }
		public DateTime FechaNacimiento { set; get; }
		public char sexo { set; get; }
		public string Ocupacion { set; get; }

		public Persona(string nombre, string apellido)
		{
			this.Nombre = nombre;
			this.Apellido = apellido;
		}

		public virtual string NombreCompleto
		{
			get
			{
				return string.Format("{0} {1} ", this.Nombre, this.Apellido);
			}
		}

		/// <summary>
		/// Modificacon de la clase object
		/// </summary>
		/// <returns>Sobre escritura</returns>
		public override string ToString()
		{
			return string.Format("{0} {1}", this.Nombre, this.Apellido);

		}


	}
}
