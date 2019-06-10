using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class Operaciones
	{
		
		
		public int numerador{ set; get; }
		public int denominador { set; get; }
		public int resultado { set; get; }

		public void Suma()
		{
			resultado = numerador + denominador;
			Console.WriteLine("La suma: " + resultado);

		}


		public void resta()
		{
			resultado = numerador - denominador;
			Console.WriteLine("La resta: " + resultado);

		}


		public void Multiplicacion()
		{
			resultado = numerador * denominador;
			Console.WriteLine("La multiplicacion: " + resultado);

		}

		public void Factorial()
		{
			for(int i = 1; i==numerador; i++)
			{
				numerador *=i;

			}
			Console.WriteLine(numerador);
		}
		public void Imprimir()
		{
			Suma();
			resta();
			Multiplicacion();
			Factorial();
		}

	}

}
