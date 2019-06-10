using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public static class Extenciones
	{
		public static int TotalPalabras(this String str)
		{
			return str.Split(new char[] { ' ', '.', '?' },
				StringSplitOptions.RemoveEmptyEntries).Length;

		}

	}
}
