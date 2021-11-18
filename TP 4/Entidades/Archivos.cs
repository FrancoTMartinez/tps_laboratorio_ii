using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
	public class Archivos <T> where T : class
	{
		public Archivos(){}


		/// <summary>
		/// Serializa los datos de la lista que recibe por parametro y las escribe en un json. Caso de que no exista el directorio, lo crea.
		/// </summary>
		/// <param name="lista"></param>
		/// <returns></returns>
		public bool SerializingList(List<T> lista)
		{
			try
			{
				string type = typeof(T).FullName;

				string file_name= Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\" + "Serialize" + $"{type}" + ".json";


				if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\"))
				{

					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\");
				}


				string serializedList = JsonSerializer.Serialize(lista);
				JsonSerializerOptions opcionesJson = new JsonSerializerOptions();
				opcionesJson.WriteIndented = true;

				File.WriteAllText(file_name, serializedList);
				return true;
			}

			catch (Exception)
			{
				throw;
			}

		}

		/// <summary>
		/// Lee el archivo xml, lo desSerializa cargandolo a una lista la cual retornara con los datos cargados.
		/// </summary>
		/// <returns></returns>
		public List<T> MappingXMLToList()
		{
			try
			{
				List<T> lista = new List<T>();
				string type = typeof(T).FullName;

				string file_name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\" + "Deserialize" + $"{type}" + ".xml";

				if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\"))
				{

					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\");
				}

				using (XmlTextReader reader = new XmlTextReader(file_name))
				{
					XmlSerializer ser = new XmlSerializer((typeof(List<T>)));

					lista = (List<T>)ser.Deserialize(reader);
				}
				return lista;
			}

			catch (Exception)
			{
				throw;
			}

			
		}

		/// <summary>
		/// Serializa los datos de la lista que recibe por parametro en un xml. Caso de no existir el directorio lo crea.
		/// </summary>
		/// <param name="lista"></param>
		/// <returns></returns>
		public bool ListToXML(List<T> lista)
		{
			try
			{
				string type = typeof(T).FullName;

				string file_name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\" + "Deserialize" + $"{type}" + ".xml";

				if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\"))
				{

					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\");
				}

				using (XmlTextWriter writer = new XmlTextWriter(file_name, System.Text.Encoding.UTF8))
				{
					XmlSerializer ser = new XmlSerializer(typeof(List<T>));
					ser.Serialize(writer, lista);
				}

				return true;
			}

			catch (Exception)
			{
				throw;
			}
		}


		/// <summary>
		/// Escribe los valores de los parametros en un archivo .txt
		/// </summary>
		/// <param name="filtro"></param>
		/// <param name="respuestaPorcentaje"></param>
		/// <returns></returns>
		public bool ExportarRespuestas(string filtro, string respuestaPorcentaje) {
			
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\Resultados\";
			try {

				if (!Directory.Exists(path))
				{

					Directory.CreateDirectory(path);
				}

				File.WriteAllText(path+ $"{filtro}.txt", respuestaPorcentaje);
				return true;
			} catch (Exception e) {
				Console.WriteLine(e.Message);
				return false;
			}

		}

		public void ExportarArchivos() {
			try
			{
				Task.Run(Canal.ExportarArchivo);
				Task.Run(Admin.ExportarArchivo);
				Task.Run(Persona.ExportarArchivo);
				
			}
			catch (Exception)
			{
				throw;
			}
		}
		
	}
}
