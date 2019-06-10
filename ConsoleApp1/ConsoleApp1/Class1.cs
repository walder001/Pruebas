using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Tiempo
	{
		private int hora;
		private int minuto;
		private int segundo;
		/// <summary>
		///  Retorna el valor de la hora del tiempo
		/// </summary>
		/// <returns>Un valor entero con la hora</returns>
		public int getHora()
		{
			return hora;
		}
		
		/// <summary>
		/// Retorna el valor de la hora
		/// </summary>
		/// <returns>Un valor entero con el minuto</returns>
		public int getMinuto()
		{
			return minuto;
		}

		/// <summary>
		/// Retorna el valor de la segundo
		/// </summary>
		/// <returns>Un valor entero con el segundo</returns>
		public int getSegundo()
		{
			return segundo;
		}
		
		/// <summary>
		/// Le asigna el valor del tiempo
		/// </summary>
		/// <param name="hora">La hora del tiempo</param>
		public void setHora(int hora)
		{
			this.hora = hora;
		}

		/// <summary>
		/// Le asigna el valor de los minutos
		/// </summary>
		/// <param name="minuto">El minuto del tiempo</param>
		public void setMinuto(int minuto)
		{
			this.minuto = minuto = minuto;
		}

		/// <summary>
		/// Le asigna el valor de los segundos
		/// </summary>
		/// <returns>Los segundos del tiempo</returns>
		public void setSegundo(int segundo)
		{
			this.segundo = segundo;
		}

		public void SetTiempo(int hora, int minuto, int segundo)
		{
			this.hora = hora;
			this.minuto = minuto;
			this.segundo = segundo;

		}
		
		public void Mostrar()
		{
			Console.WriteLine("La hora es: " + hora + "Minuto: " + minuto + "Segundo: "+segundo);
		}

		

	}
}
