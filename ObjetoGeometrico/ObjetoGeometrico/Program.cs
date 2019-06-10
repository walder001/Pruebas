using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoGeometrico
{
	class Program
	{
		static void Main(string[] args)
		{
			Area a = new Area();
			a.real = 10;
			a.imaginario = 15;
			int suma = a.real + a.imaginario * a.real + a.imaginario;

			Console.WriteLine("La suma es: " + suma);
			Console.ReadLine();
		}
	}
}
