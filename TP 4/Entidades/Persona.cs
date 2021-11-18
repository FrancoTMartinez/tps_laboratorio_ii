using System;
using System.Collections.Generic;
using System.IO;
using System.Data;

namespace Entidades
{
	public delegate void CantPersonasNecesarias(List<Persona> personaList);

	[Serializable]
	public class Persona : IOperations<Persona>
	{
		public event CantPersonasNecesarias CantPersonasNecesarias;
	
		private static List<Persona> personaList;
		private static Archivos<Persona> archPersona;
		private static ConnectionDB connectionDB;
		private int id;
		private string dni;
		private string nombre;
		private string apellido;
		private int idCanal;
		private int edad;
		private string genero;


		public Persona()
		{

		}
		static Persona()
		{
			archPersona = new Archivos<Persona>();
			personaList = new List<Persona>();
			connectionDB = new ConnectionDB();
		}

		public Persona(string dni, string nombre, string apellido, int idCanal, int edad, string genero)
		{
			this.Dni = dni;
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.IdCanal = idCanal;
			this.Edad = edad;
			this.Genero = genero;
		}
		public Persona(int id, string dni, string nombre, string apellido, int idCanal, int edad, string genero) :this(dni ,nombre,apellido,idCanal, edad,genero)
		{
			this.Id = id;
		}

		public int Id { get { return id; } set { id = value; } }
		public string Dni { get { return dni; } set { dni = value; } }
		public string Nombre { get { return nombre; } set { nombre = value; } }
		public string Apellido { get { return apellido; } set { apellido = value; } }
		public int IdCanal { get { return idCanal; } set { idCanal = value; } }
		public int Edad { get { return edad; } set { edad = value; } }
		public string Genero { get { return genero; } set { genero = value; } }

		/// <summary>
		/// Metodo que hace el invoke del delegado asociado al evento
		/// </summary>
		public void ContarPeronas()
		{
			if (CantPersonasNecesarias != null)
			{
				CantPersonasNecesarias.Invoke(Persona.GetList());
			}
		}

		/// <summary>
		/// Agrega un obj del tipo Persona a la base de datos
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool AddToDB(Persona obj)
		{
			try
			{
				connectionDB.Command.CommandText = $"INSERT INTO TablePersonas(DNI,Nombre,Apellido,IDCanal,Edad,Genero) " +
													$"Values(@DNI,@Nombre,@Apellido,@IDCanal,@Edad,@Genero)";
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.AddWithValue("@DNI", obj.Dni);
				connectionDB.Command.Parameters.AddWithValue("@Nombre", obj.Nombre);
				connectionDB.Command.Parameters.AddWithValue("@Apellido", obj.Apellido);
				connectionDB.Command.Parameters.AddWithValue("@IDCanal", obj.IdCanal);
				connectionDB.Command.Parameters.AddWithValue("@Edad", obj.Edad);
				connectionDB.Command.Parameters.AddWithValue("@Genero", obj.Genero);

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
		/// Elimina un elemento de la base de datos por su ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public bool DeleteFromDB(int id)
		{
			try
			{
				connectionDB.Command.CommandText = $"DELETE FROM TablePersonas Where TablePersonas.ID= @ID";
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
		/// Modifica un obj de la base de datos por su ID
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool UpdateFromDB(Persona obj)
		{
			try
			{
				connectionDB.Command.CommandText = $"UPDATE TablePersonas SET DNI= @DNI," +
																			$"Nombre=@Nombre," +
																			$"Apellido=@Apellido," +
																			$"IDCanal=@IDCanal," +
																			$"Edad=@Edad," +
																			$"Genero=@Genero " +
																			$"where ID=@ID";
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.AddWithValue("@DNI", obj.Dni);
				connectionDB.Command.Parameters.AddWithValue("@Nombre", obj.Nombre);
				connectionDB.Command.Parameters.AddWithValue("@Apellido", obj.Apellido);
				connectionDB.Command.Parameters.AddWithValue("@IDCanal", obj.IdCanal);
				connectionDB.Command.Parameters.AddWithValue("@Edad", obj.Edad);
				connectionDB.Command.Parameters.AddWithValue("@Genero", obj.Genero);
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
		/// Retorna un objeto del tipo persona encontrandolo por el numero de dni 
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public Persona SearchByDNI(string dni)
		{
			try
			{
				connectionDB.Command.CommandText = $"SELECT * FROM TablePersonas WHERE TablePersonas.DNI= @DNI ";
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.AddWithValue("@DNI", dni);

				if (connectionDB.Connection.State != ConnectionState.Open)
				{
					connectionDB.Connection.Open();
				}

				connectionDB.Reader = connectionDB.Command.ExecuteReader();
				Persona persona = null ;
				while (connectionDB.Reader.Read())
				{
					persona = new Persona(int.Parse(connectionDB.Reader["ID"].ToString()),
													connectionDB.Reader["DNI"].ToString(),
													connectionDB.Reader["Nombre"].ToString(),
													connectionDB.Reader["Apellido"].ToString(),
													int.Parse(connectionDB.Reader["IDCanal"].ToString()),
													int.Parse(connectionDB.Reader["Edad"].ToString()),
													connectionDB.Reader["Genero"].ToString());
				}
				return persona;

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

		/// <summary>
		/// Obtengo la lista estatica sin embargo antes la actualizo realizando una request a la base de datos
		/// </summary>
		/// <returns></returns>
		static public List<Persona> GetList()
		{
			try
			{
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
			return personaList;
		}

		/// <summary>
		/// Actualizo la lista estatica para luego escribir un archivo xml
		/// </summary>
		static public void ExportarArchivo()
		{
			personaList = GetList();
			archPersona.ListToXML(personaList);
		}

		public override string ToString()
		{
			return "DNI: " + this.Dni + " Nombre: " + this.Nombre + " Apellido: " + this.Apellido +
					" Voto: " + this.IdCanal + " Edad: " + this.Edad + " Genero: " + this.Genero;
		}
	}
}
