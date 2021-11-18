using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	[Serializable]
	public class Canal : IOperations<Canal>
	{
		private static List<Canal> canalList;
		private static Archivos<Canal> archCanal;
		private static ConnectionDB connectionDB;
		private int id;
		private string nombre;

		public Canal() {
			
		}
		static Canal(){
			archCanal = new Archivos<Canal>();
			canalList = new List<Canal>();
			connectionDB = new ConnectionDB();
		}

		public Canal(string nombre)
		{
			this.Nombre = nombre;
		}
		public Canal(int id, string nombre) :this(nombre)
		{
			this.Id = id;
		}

		public int Id { get => id; set => id = value; }
		public string Nombre { get => nombre; set => nombre = value; }

		/// <summary>
		/// Agrega un obj del tipo Canal a la base datos
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool AddToDB(Canal obj)
		{
			try
			{
				connectionDB.Command.CommandText = $"INSERT INTO TableCanales(Nombre) " +
													$"Values(@Nombre)";
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.AddWithValue("@Nombre", obj.Nombre);

				if (connectionDB.Connection.State != ConnectionState.Open)
				{
					connectionDB.Connection.Open();
				}

				connectionDB.Command.ExecuteNonQuery();

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				connectionDB.Reader.Close();
				connectionDB.Connection.Close();

			}
			return true;
		}

		/// <summary>
		/// Elimina un elemento de la base de datos encontrandolo por ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public bool DeleteFromDB(int id)
		{
			try
			{
				connectionDB.Command.CommandText = $"DELETE FROM TableCanales Where TableCanales.ID= @ID";
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.AddWithValue("@ID", id);

				if (connectionDB.Connection.State != ConnectionState.Open)
				{
					connectionDB.Connection.Open();
				}

				connectionDB.Command.ExecuteNonQuery();

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				connectionDB.Reader.Close();
				connectionDB.Connection.Close();

			}
			return true;
		}

		/// <summary>
		/// Modifica un obj de la base de datos encontrandolo por ID
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool UpdateFromDB(Canal obj)
		{
			try
			{
				connectionDB.Command.CommandText = $"UPDATE TableCanales SET Nombre= @Nombre " +
																			$"where ID=@ID";
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.AddWithValue("@Nombre", obj.Nombre);
				connectionDB.Command.Parameters.AddWithValue("@ID", obj.Id);

				if (connectionDB.Connection.State != ConnectionState.Open)
				{
					connectionDB.Connection.Open();
				}

				connectionDB.Command.ExecuteNonQuery();

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				connectionDB.Reader.Close();
				connectionDB.Connection.Close();

			}
			return true;
		}

		/// <summary>
		/// Obtengo la lista estatica sin embargo antes la actualizo realizando una request a la base de datos
		/// </summary>
		/// <returns></returns>
		static public List<Canal> GetList()
		{
			try
			{
				canalList.Clear();
				connectionDB.Command.CommandText = $"SELECT * FROM TableCanales";
				connectionDB.Command.Parameters.Clear();

				if (connectionDB.Connection.State != ConnectionState.Open)
				{
					connectionDB.Connection.Open();
				}

				connectionDB.Reader = connectionDB.Command.ExecuteReader();

				while (connectionDB.Reader.Read())
				{
					canalList.Add(new Canal(int.Parse(connectionDB.Reader["ID"].ToString()),
												   connectionDB.Reader["Nombre"].ToString()));
				}
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				connectionDB.Reader.Close();
				connectionDB.Connection.Close();

			}
			return canalList;
		}

		/// <summary>
		///  Retorna un objeto del tipo Canal encontrandolo por el nombre
		/// </summary>
		/// <param name="nombreCanal"></param>
		/// <returns></returns>
		static public Canal SearchByName(string nombreCanal)
		{
			try
			{
				connectionDB.Command.CommandText = $"SELECT * FROM TableCanales WHERE TableCanales.Nombre= @Nombre";
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.AddWithValue("@Nombre", nombreCanal);

				if (connectionDB.Connection.State != ConnectionState.Open)
				{
					connectionDB.Connection.Open();
				}

				connectionDB.Reader = connectionDB.Command.ExecuteReader();
				Canal canal = null;

				while (connectionDB.Reader.Read())
				{
					canal = new Canal(int.Parse(connectionDB.Reader["ID"].ToString()),
												   connectionDB.Reader["Nombre"].ToString());
				}
				return canal;

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				connectionDB.Reader.Close();
				connectionDB.Connection.Close();

			}
		}

		public override string ToString()
		{
			return "Id: " + this.Id + " Nombre: " + this.Nombre;
		}

		/// <summary>
		/// Obtengo el id del canal buscandolo por nombre
		/// </summary>
		/// <param name="nombre"></param>
		/// <returns></returns>
		public static int GetIdByName(string nombre)
		{
			foreach (Canal canal in canalList)
			{
				if (canal.Nombre == nombre)
				{
					return canal.Id;
				}
			}

			return 0;
		}

		/// <summary>
		/// Obtengo el nombre del canal buscandolo por ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static string GetNameById(int id)
		{
			foreach (Canal canal in canalList)
			{
				if (canal.Id == id)
				{
					return canal.Nombre;
				}
			}

			return null;
		}

		/// <summary>
		/// Actualizo la lista estatica para luego escribir un archivo xml
		/// </summary>
		static public void ExportarArchivo()
		{
			canalList = GetList();
			archCanal.ListToXML(canalList);
		}
	}
}
