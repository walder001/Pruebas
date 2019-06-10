using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		enum diasSemana { LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO};
		static void Main(string[] args)
		{
			Persona p = new Persona();
			p.Nombre = "Walder";
			p.Apellido = "Reyes";

			Console.WriteLine(p.ToString());

			Estudiante es = new Estudiante
			{

				Nombre = "Ana";



			}


			DateTime da = DateTime.Now;
			Console.WriteLine(da.imprimirTiempo(FormatoTiempo.MILITAR));
			double venta = 15000;
			double comision = (venta < 1500) ? (venta * 0.10) : (venta * 0.15);
			Console.WriteLine("La comiscion por la venta es {0} es de {1}.", venta, comision);
			Console.ReadLine();

			Console.WriteLine(string.Format("{0:N3}", -1222));
			double valor = 1233322.22;
			Console.WriteLine(valor.ToString("#,###.00; (#,###.00); 0.00"));

			DateTime fecha = DateTime.Now.Date;
			Console.WriteLine(fecha.ToShortDateString());
			Console.WriteLine(fecha.ToLongDateString());
			Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
			Console.WriteLine("La fecha es {0:yyyy/MM/dd}", fecha);
			Console.ReadLine();

			int d = Convert.ToInt32("123456");
			double d1 = Convert.ToDouble("123.12");
			bool d2 = Convert.ToBoolean("true");
			bool d3 = Convert.ToBoolean(0);
			Console.WriteLine(d);

			Console.WriteLine();

			string[] nombres = { "Walder", "Wadeline", "Wailyn" };
			int[] edades = { 1, 2, 3, 4, 5, 6 };
			for (int j = 0; j < nombres.Length; j++)
				Console.WriteLine(nombres[j]);
			   Console.Read();

			foreach (string nombre in nombres)
				Console.WriteLine(nombre);

			foreach (int edad in edades)
				Console.WriteLine(edad);

			Console.ReadLine();

			Operaciones i = new Operaciones();
			i.numerador = 100;
			i.denominador = 10;
			i.Imprimir();
			Console.ReadKey();


 
		}
		
	}
}
