using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
	public class ConnectionDB
	{
		private SqlConnection connection;
		private SqlCommand command;
		private SqlDataReader reader;

		public ConnectionDB()
		{
			Connection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS;Database = TP4_Final_FrancoTobiasMartinez_2E;Trusted_Connection = True;");
			command = new SqlCommand();

			Command.CommandType = CommandType.Text;
			Command.Connection = Connection;
		}

		public SqlConnection Connection { get => connection; set => connection = value; }
		public SqlCommand Command { get => command; set => command = value; }
		public SqlDataReader Reader { get => reader; set => reader = value; }
	}
}
