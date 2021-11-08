using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;

namespace Entidades
{
	[Serializable]
	public class Admin : IOperations<Admin>
	{
		private static List<Admin> adminList;
		private static Archivos<Admin> archAdmin;
		private static int idStatic = 0;
		private int id;
		private string dni;
		private string user;
		private string password;

		public Admin()
		{

		}
		public Admin(string dni, string user, string password)
		{
			idStatic = idStatic + 1;
			this.id = idStatic;
			this.Dni = dni;
			this.User = user;
			this.Password = password;
		}

		static Admin()
		{
			archAdmin = new Archivos<Admin>();
			adminList = new List<Admin>();
			GetLastId();

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

		public bool AddToList(Admin obj)
		{
			foreach (Admin admin in adminList)
			{
				if (admin.User == obj.User)
				{
					return false;
				}
			}

			adminList.Add(obj);
			archAdmin.ListToXML(adminList);

			return true;
		}

		public bool DeleteFromList(int id)
		{
			try
			{

				if (id > 0)
				{
					foreach (Admin admin in adminList)
					{
						if (admin.Id == id)
						{
							adminList.Remove(admin);
							archAdmin.ListToXML(adminList);
							return true;
						}

					}
				}
				return false;
			}
			catch (NullReferenceException)
			{

				throw;
			}
		}

		public bool UpdateFromList(Admin obj)
		{
			foreach (Admin admin in adminList)
			{
				if ((admin.User == obj.User && admin.Id != obj.Id) || (admin.Dni == obj.Dni && admin.Id != obj.Id))
				{
					return false;
				}
				else
				{
					if (admin.Id == obj.Id)
					{
						admin.Dni = obj.Dni;
						admin.User = obj.User;
						admin.Password = obj.Password;
						archAdmin.ListToXML(adminList);

						return true;
					}
				}

			}

			return false;
		}

		static public List<Admin> GetList()
		{
			return adminList;
		}

		static public Admin GetAdminByDNI(string dni)
		{
			foreach (Admin admin in adminList)
			{
				if (admin.Dni == dni)
				{
					return admin;
				}
			}

			return null;
		}

		static public bool ValidateExistingDNI(string dni)
		{
			foreach (Admin admin in adminList)
			{
				if (admin.Dni == dni)
				{
					return false;
				}
			}
			return true;
		}


		internal static int GetLastId()
		{

			foreach (Admin admin in adminList)
			{
				idStatic = admin.Id;
			}
			return 1;
		}
		private static void CargarListaDesdeHardcodeo()
		{
			adminList.Add(new Admin("42416954", "admin", "admin"));
		}

		static public bool VerificarArchivoAdmin()
		{
			string type = typeof(Admin).FullName;
			string file_name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\" + "Deserialize" + $"{type}" + ".xml";

			if (!File.Exists(file_name))
			{
				CargarListaDesdeHardcodeo();
				archAdmin.ListToXML(adminList);
				return false;
			}
			else
			{
				adminList = archAdmin.MappingXMLToList();
			}
			return true;
		}
	}
}
