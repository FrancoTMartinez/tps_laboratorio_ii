using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data;

namespace EntidadesTests
{
	[TestClass]
	public class ConnectionDBTest
	{
		[TestMethod]
		public void ConnectionStateOfDBisOpen()
		{
			ConnectionDB connectionDB = new ConnectionDB();
			if (connectionDB.Connection.State != ConnectionState.Open)
			{
				connectionDB.Connection.Open();
			}

			Assert.AreEqual("Open", ConnectionState.Open.ToString());
		}


		[TestMethod]
		public void ConnectionStateOfDBisClose()
		{
			ConnectionDB connectionDB = new ConnectionDB();
			List<Persona> personaList = new List<Persona>();

			personaList.Clear();
			connectionDB.Command.CommandText = $"SELECT * FROM TablePersonas";
			connectionDB.Command.Parameters.Clear();

			if (connectionDB.Connection.State != ConnectionState.Open)
			{
				connectionDB.Connection.Open();
			}

			connectionDB.Reader = connectionDB.Command.ExecuteReader();

			while (connectionDB.Reader.Read())
			{
				personaList.Add(new Persona(int.Parse(connectionDB.Reader["ID"].ToString()),
											   connectionDB.Reader["DNI"].ToString(),
											   connectionDB.Reader["Nombre"].ToString(),
											   connectionDB.Reader["Apellido"].ToString(),
											   int.Parse(connectionDB.Reader["IDCanal"].ToString()),
											   int.Parse(connectionDB.Reader["Edad"].ToString()),
											   connectionDB.Reader["Genero"].ToString()));
			}

			connectionDB.Reader.Close();
			connectionDB.Connection.Close();

			Assert.IsNotNull(personaList);
		}
	}
}
