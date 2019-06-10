using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Persona p = new Persona();
			p.nombre = "walder";
			p.apellido = "Reyes";
			p.sexo = 'M';

			List<Persona> p1 = new List<Persona>();
			p1.Add(new Persona("Walder", "Reyes"));
			foreach (Persona persona in p1)

				Console.WriteLine(persona.ToString());
			    Console.ReadLine();*/


			List<int> entero = new List<int>();
			entero.Add(10);
			foreach (int enteros in entero)
			{
				Console.WriteLine(entero.ToString());
			}
			Console.ReadLine();

			StringBuilder cadena = new StringBuilder();
			cadena.Append("Walder");
			cadena.AppendFormat("{0} es el mejero profesor","Neson");
			cadena.AppendLine("Esto sale de otra linea");
			Console.Write(cadena);
			Console.ReadKey();
				

			
		}
	}
}
