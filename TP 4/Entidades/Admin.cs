using Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Entidades
{
	[Serializable]
	public class Admin : IOperations<Admin>
	{
		private static List<Admin> adminList;
		private static Archivos<Admin> archAdmin;
		private static ConnectionDB connectionDB;
		private int id;
		private string dni;
		private string user;
		private string password;

		public Admin()
		{

		}
		public Admin(string dni, string user, string password)
		{
			this.Dni = dni;
			this.User = user;
			this.Password = password;
		}
		public Admin(int id, string dni, string user, string password): this(dni,user,password)
		{
			this.Id = id;
		}

		static Admin()
		{
			archAdmin = new Archivos<Admin>();
			adminList = new List<Admin>();
			connectionDB = new ConnectionDB();
		}

		public string Dni
		{
			get { return dni; }
			set { dni = value; }
		}
		public string User
		{
			get { return user; }
			set
			{
				if (value != string.Empty && Validar.ValidarCadenaTexto(value))
				{
					user = value;
				}
				else
				{
					throw new AdminUserException("Usuario invalido.");
				}
			}
		}
		public string Password { 
			get { return password; } 
			set {
				if (value != string.Empty)
				{
					password = value;
				}
				else {
					throw new AdminPasswordExceptioncs("La password no puede ser vacia.");
				}
				 
			} }
		public int Id { get { return id; } set { id = value; } }


		/// <summary>
		/// Agrega un obj del tipo Admin a la base datos
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool AddToDB(Admin obj)
		{
			try
			{
				connectionDB.Command.CommandText = $"INSERT INTO TableAdministradores(DNI,Usuario,Password) " +
													$"Values(@DNI,@Usuario,@Password)";
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.AddWithValue("@DNI", obj.Dni);
				connectionDB.Command.Parameters.AddWithValue("@Usuario", obj.User);
				connectionDB.Command.Parameters.AddWithValue("@Password", obj.Password);

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
				connectionDB.Command.CommandText = $"DELETE FROM TableAdministradores Where TableAdministradores.ID= @ID";
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
		public bool UpdateFromDB(Admin obj)
		{
			try
			{
				connectionDB.Command.CommandText = $"UPDATE TableAdministradores SET DNI= @DNI," +
																			$"Usuario=@Usuario," +
																			$"Password=@Password "+
																			$"where ID=@ID";
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.Clear();
				connectionDB.Command.Parameters.AddWithValue("@DNI", obj.Dni);
				connectionDB.Command.Parameters.AddWithValue("@Usuario", obj.User);
				connectionDB.Command.Parameters.AddWithValue("@Password", obj.Password);
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
		static public List<Admin> GetList()
		{
			
			try
			{
				adminList.Clear();
				connectionDB.Command.CommandText = $"SELECT * FROM TableAdministradores";
				connectionDB.Command.Parameters.Clear();
				

				if (connectionDB.Connection.State != ConnectionState.Open)
				{
					connectionDB.Connection.Open();
				}

				connectionDB.Reader = connectionDB.Command.ExecuteReader();

				while (connectionDB.Reader.Read())
				{
					adminList.Add(new Admin(int.Parse(connectionDB.Reader["ID"].ToString()),
										connectionDB.Reader["DNI"].ToString(),
										connectionDB.Reader["Usuario"].ToString(),
										connectionDB.Reader["Password"].ToString()));
					
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
			return adminList;
		}

		/// <summary>
		/// Obtengo un objeto del tipo Admin encontrandolo por dni
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public Admin GetAdminByDNI(string dni)
		{
			adminList = GetList();
			foreach (Admin admin in adminList)
			{
				if (admin.Dni == dni)
				{
					return admin;
				}
			}

			return null;
		}

		/// <summary>
		/// Verifico que el dni a ingresar no este utilizado por otro administrador
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public bool ValidateExistingDNI(string dni)
		{
			adminList = GetList();
			foreach (Admin admin in adminList)
			{
				if (admin.Dni == dni)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Actualizo la lista estatica para luego escribir un archivo xml
		/// </summary>
		static public void ExportarArchivo()
		{
			adminList = GetList();
			archAdmin.ListToXML(adminList);
		}
	}
}
