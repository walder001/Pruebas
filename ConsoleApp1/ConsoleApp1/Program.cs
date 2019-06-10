using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Contabilidad;
using ConsoleApp1.Contabilidad.Impositiva;
using System.Collections;



namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Presupuesto p = new Presupuesto();
			ConciliacionBanacaria c = new ConciliacionBanacaria();

			double venta = 15000;
			double comision = (venta < 1500) ? (venta * 0.10) : (venta * 0.15);
			Console.WriteLine("La comiscion por la venta es {0} es de {1}.", venta, comision);
			Console.ReadLine();

			Tiempo t = new Tiempo();
			t.setHora(20);
			t.setMinuto(30);
			t.setSegundo(20);
			Fecha f = new Fecha();

			Console.WriteLine("Hora: "+t.getHora()+" \nMinuto: "+t.getMinuto()+" \nSegundo: "+t.getSegundo()+"\n");
		     Console.WriteLine(f.getFecha());

			Console.WriteLine("#\t\tBisiesto");
			for(int i = 1996; i<=DateTime.Now.Year; i++)
			{
				if(Fecha.EsBiciesto(i))
					Console.WriteLine(String.Format("{0}\t\t{1}",i,Fecha.EsBiciesto(i) ? "Si" : "No"));
			}
			Console.WriteLine(f[1]);
			Console.WriteLine(f[2]);
			Console.WriteLine(f[3]);

			f[1] = 50;
			f[2] = 40;
			f[3] = 60;
			Console.WriteLine(f[1]);
			Console.WriteLine(f[2]);
			Console.WriteLine(f[3]);
			Console.ReadKey();

			
			

			string[] nom = { "Walder", "Reyes", "De", "Jesus"};
			Array.Sort(nom);
			foreach (string nom in noms)
				Console.WriteLine(nom);
            Console.ReadKey();

			ArrayList arr =  new ArrayList();
			arr.Add(23);
			arr.Add(40);

			List<Persona>
		







			



	
		}
	}
}
