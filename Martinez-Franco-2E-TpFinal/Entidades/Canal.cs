using System;
using System.Collections.Generic;
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
		private static int idStatic=0;
		private int id;
		private string nombre;

		public Canal() {
			
		}
		static Canal(){
			archCanal = new Archivos<Canal>();
			canalList = new List<Canal>();
			GetLastId();
		}

		public Canal(string nombre)
		{
			idStatic = idStatic + 1;
			this.Id = idStatic;
			this.Nombre = nombre;
		}

		public int Id { get => id; set => id = value; }
		public string Nombre { get => nombre; set => nombre = value; }

		/// <summary>
		/// Agrega un obj del tipo Canal a la lista, luego escribe el documento de personas con la lista actualizada
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool AddToList(Canal obj)
		{
			canalList.Add(obj);
			archCanal.ListToXML(canalList);

			return true;
		}

		/// <summary>
		/// Elimina un elemento de la lista buscandolo por id, luego escribe el documento de personas con la lista actualizada
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public bool DeleteFromList(int id)
		{
			foreach (Canal canal in canalList)
			{
				if (canal.Id == id)
				{
					canalList.Remove(canal);
					archCanal.ListToXML(canalList);
					return true;

				}
			}
			return false;
		}

		/// <summary>
		/// Modifica un obj de la lista encontrandolo por id, antes de modificarlo se verifica que el nombre 
		/// no se encuentre en uso por otro canal. Luego escribe el documento de personas con la lista actualizada
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool UpdateFromList(Canal obj)
		{
			foreach (Canal canal in canalList)
			{
				if (canal.Nombre == obj.Nombre && canal.Id != obj.Id)
				{
					return false;
				}
				else
				{
					if (canal.Id == obj.Id)
					{
						canal.Nombre = obj.Nombre;
						archCanal.ListToXML(canalList);

						return true;
					}
				}

			}

			return false;
		}

		/// <summary>
		/// Obtengo la lista estatica
		/// </summary>
		/// <returns></returns>
		static public List<Canal> GetList()
		{
			return canalList;
		}

		/// <summary>
		///  Retorna un objeto del tipo Canal encontrandolo por el nombre
		/// </summary>
		/// <param name="nombreCanal"></param>
		/// <returns></returns>
		static public Canal SearchByName(string nombreCanal)
		{
			foreach (Canal canal in canalList)
			{
				if (canal.Nombre == nombreCanal)
				{
					return canal;
				}
			}
			return null;
		}

		/// <summary>
		/// Obtengo el ultimo id del ultimo elemento de la lista y se lo asigno al idStatic
		/// </summary>
		/// <returns></returns>
		internal static int GetLastId()
		{	

			foreach (Canal canal in canalList)
			{
				idStatic= canal.Id;
			}
			return 1;
		}
		public override string ToString()
		{
			return "Id: " + this.Id + " Nombre: " + this.Nombre;
		}

		/// <summary>
		/// Agrego datos Hardcodeados a la lista estatica
		/// </summary>
		private static void CargarListaDesdeHardcodeo() {

			canalList.Add(new Canal("Telefe"));
			canalList.Add(new Canal("El trece"));
			canalList.Add(new Canal("America"));
			canalList.Add(new Canal("Canal 9"));
			canalList.Add(new Canal("Tv Publica"));
			canalList.Add(new Canal("Ninguno"));
		}

		/// <summary>
		/// Verifico si el archivo del que se quieren cargar los datos exista, caso contrario cargo la lista de datos harcodeados
		/// y escribo el archivo necesario y obtengo el ultimo id.
		/// </summary>
		static public void VerificarArchivoCanal()
		{
			string type = typeof(Canal).FullName;
			string file_name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\" + "Deserialize" + $"{type}" + ".xml";

			if (!File.Exists(file_name))
			{
				CargarListaDesdeHardcodeo();

				archCanal.ListToXML(canalList);
				
			}
			else {
				canalList = archCanal.MappingXMLToList();
				GetLastId();
			}
		}
	}
}
