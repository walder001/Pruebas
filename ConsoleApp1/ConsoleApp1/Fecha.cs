using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Fecha
	{
		public int Dia { get; set; }
		public int Mes { get; set; }
		public int Ano { get; set; }

		public static bool EsBiciesto(int year)
		{
			return DateTime.IsLeapYear(year);
		}


		public Fecha()
		{
			Dia = 1;
			Mes = 2;
			Ano = 23;
		}
		public Fecha(int dia, int mes, int ano)
		{
			Dia = dia;
			Mes = mes;
			Ano = ano;

		}
		public string getFecha()
		{

			return string.Format("{0}-{1}-{2}", Dia, Mes, Ano);

		}

		public int this[int numeroColumn]
		{
			get
			{
				switch (numeroColumn)
				{
					case 1:
						return Dia;
					case 2:
						return Mes;
					case 3:
						return Ano;

				}
				return 0;
			}

			set
			{
				switch (numeroColumn)
				{
					case 1:
						this.Dia = value;
						break;
					case 2:
						this.Mes = value;
						break;
					case 3:
						this.Ano = value;
						break;
				}
			}
		}


	}

}
