using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SistemaUniversitario
{
	public class Conexion
	{
		public SqlConnection LeerCadena()
		{
			SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Unica"].ConnectionString);
			if(con.State == System.Data.ConnectionState.Open)
			{
				con.Close();
			}
			else
			{
				con.Open();
			}
			return con;

		}

	}
}
