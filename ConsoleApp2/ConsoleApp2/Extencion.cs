using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public enum FormatoTiempo {	STANDARD, MILITAR};
	public enum FormatoFecha { DMY, MDY, YDM};
	public static class Extencion
	{
		public static string imprimirTiempo(this DateTime dt, FormatoTiempo formato)
		{

			if(formato == FormatoTiempo.STANDARD)
				return dt.ToShortTimeString();
			return dt.ToLongTimeString();

		}
	}
}
