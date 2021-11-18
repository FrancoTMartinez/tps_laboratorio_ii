using System;
using System.Collections.Generic;
using System.IO;

namespace Entidades
{
	[Serializable]
	public class Persona : IOperations<Persona>
	{
		private static List<Persona> personaList;
		private static Archivos<Persona> archPersona;
		private static int idStatic = 0;
		private int id;
		private string dni;
		private string nombre;
		private string apellido;
		private string voto;
		private int edad;
		private string genero;

		public Persona()
		{


		}
		static Persona()
		{

			archPersona = new Archivos<Persona>();
			personaList = new List<Persona>();
			GetLastId();

		}

		public Persona(string dni, string nombre, string apellido, string voto, int edad, string genero)
		{
			idStatic = idStatic + 1;
			this.Id = idStatic;
			this.Dni = dni;
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Voto = voto;
			this.Edad = edad;
			this.Genero = genero;
		}


		public int Id { get { return id; } set { id = value; } }
		public string Dni { get { return dni; } set { dni = value; } }
		public string Nombre { get { return nombre; } set { nombre = value; } }
		public string Apellido { get { return apellido; } set { apellido = value; } }
		public string Voto { get { return voto; } set { voto = value; } }
		public int Edad { get { return edad; } set { edad = value; } }
		public string Genero { get { return genero; } set { genero = value; } }

		/// <summary>
		/// Agrega un obj del tipo Persona a la lista, luego escribe el documento de personas con la lista actualizada
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool AddToList(Persona obj)
		{
			personaList.Add(obj);
			archPersona.ListToXML(personaList);

			return true;

		}

		/// <summary>
		/// Elimina un elemento de la lista buscandolo por id, luego escribe el documento de personas con la lista actualizada
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public bool DeleteFromList(int id)
		{
			if (id > 0)
			{
				foreach (Persona persona in personaList)
				{
					if (persona.Id == id)
					{

						personaList.Remove(persona);
						archPersona.ListToXML(personaList);
						return true;

					}
				}
			}
			return false;
		}

		/// <summary>
		/// Modifica un obj de la lista encontrandolo por id, antes de modificarlo se verifica que el numero de dni en caso de 
		/// querer modificarlo no se encuentre en uso por otra persona.. Luego escribe el documento de personas con la lista actualizada
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool UpdateFromList(Persona obj)
		{

			foreach (Persona persona in personaList)
			{
				if (persona.Dni == obj.Dni && persona.Id != obj.Id)
				{
					return false;
				}
				else
				{
					if (persona.Id == obj.Id)
					{

						persona.Dni = obj.Dni;
						persona.Nombre = obj.Nombre;
						persona.Apellido = obj.Apellido;
						persona.Voto = obj.Voto;
						persona.Edad = obj.Edad;
						persona.Genero = obj.Genero;


						archPersona.ListToXML(personaList);

						return true;
					}
				}

			}

			return false;
		}

		/// <summary>
		/// Retorna un objeto del tipo persona encontrandolo por el numero de dni
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public Persona SearchByDNI(string dni)
		{

			foreach (Persona persona in personaList)
			{
				if (persona.Dni == dni)
				{
					return persona;
				}
			}
			return null;
		}

		/// <summary>
		/// Obtengo la lista estatica
		/// </summary>
		/// <returns></returns>
		static public List<Persona> GetList()
		{
			return personaList;
		}
		/// <summary>
		/// Cargo la lista estatica con los datos del archivo
		/// </summary>
		static public void CargarListaDesdeArchivo()
		{
			personaList = archPersona.MappingXMLToList();
		}

		/// <summary>
		/// Agrego datos Hardcodeados a la lista estatica
		/// </summary>
		private static void CargarListaDesdeHardcodeo() {
			personaList.Add(new Persona("42416954", "Franco", "Martinez", "Telefe", 21, "masculino"));
			personaList.Add(new Persona("18687978", "Eladio", "Martinez", "El trece", 53, "masculino"));
			personaList.Add(new Persona("22750836", "Norma", "Ester", "Canal 9", 49, "femenino"));
			personaList.Add(new Persona("22416954", "Juan Cruz", "Perco", "Tv Publica", 22, "masculino"));
			personaList.Add(new Persona("48687978", "Franco", "Guimmarra", "America", 21, "masculino"));
			personaList.Add(new Persona("52750836", "Loana", "Rubio", "Ninguno", 35, "femenino"));
			personaList.Add(new Persona("62416954", "Marcelo", "Rubio", "Telefe", 55, "masculino"));
			personaList.Add(new Persona("78687978", "Mariela", "Rubio", "Ninguno", 47, "femenino"));
			personaList.Add(new Persona("82750836", "Milena", "Rubio", "Canal 9", 17, "femenino"));
			personaList.Add(new Persona("92416954", "Alext", "Tudisca", "Telefe", 34, "masculino"));
			personaList.Add(new Persona("10687978", "Fernando", "Oviedo", "Ninguno", 60, "masculino"));
			personaList.Add(new Persona("11750836", "Claudio", "Tudisca", "Telefe", 55, "masculino"));

			personaList.Add(new Persona("14141414", "Julieta", "Cabral", "Tv Publica", 21, "femenino"));
			personaList.Add(new Persona("15151515", "Nayla", "Tudisca", "El trece", 55, "femenino"));
			personaList.Add(new Persona("16161616", "Norma", "Ester", "Canal 9", 47, "femenino"));
			personaList.Add(new Persona("17171717", "Cruz Juan", "Perco", "Telefe", 22, "masculino"));
			personaList.Add(new Persona("18181818", "Federico", "Guimmarra", "America", 21, "masculino"));
			personaList.Add(new Persona("19191919", "Clara", "Rubio", "Ninguno", 35, "femenino"));
			personaList.Add(new Persona("12121212", "Daniel", "Rubio", "Telefe", 55, "no binario"));
			personaList.Add(new Persona("13131313", "Daniela", "Rubio", "Ninguno", 47, "femenino"));
			personaList.Add(new Persona("21212121", "Maitena", "Rubio", "Canal 9", 17, "femenino"));
			personaList.Add(new Persona("21222222", "Oscar", "Tudisca", "Telefe", 34, "masculino"));
			personaList.Add(new Persona("23232323", "Tito", "Oviedo", "Ninguno", 60, "masculino"));
			personaList.Add(new Persona("24242424", "Silvina", "Tudisca", "Telefe", 55, "no binario"));

			personaList.Add(new Persona("26262626", "Gustavo", "Martinez", "Tv Publica", 21, "masculino"));
			personaList.Add(new Persona("25252525", "Ramiro", "Martinez", "El trece", 53, "masculino"));
			personaList.Add(new Persona("27272727", "Romina", "Ester", "Canal 9", 49, "femenino"));
			personaList.Add(new Persona("28282828", "Juan Cruz", "Perco", "Telefe", 22, "masculino"));
			personaList.Add(new Persona("29292929", "Tomas", "Guimmarra", "America", 21, "no binario"));
			personaList.Add(new Persona("30303030", "Lily", "Rubio", "Ninguno", 35, "femenino"));
			personaList.Add(new Persona("31313131", "Alejandr", "Rubio", "Telefe", 55, "masculino"));
			personaList.Add(new Persona("32323232", "Alejandra", "Rubio", "Ninguno", 47, "femenino"));
			personaList.Add(new Persona("34343434", "Belen", "Rubio", "El trece", 17, "femenino"));
			personaList.Add(new Persona("36363636", "Braian", "Tudisca", "El trece", 34, "masculino"));
			personaList.Add(new Persona("37373737", "L-Gante", "Oviedo", "Ninguno", 60, "masculino"));
			personaList.Add(new Persona("38383838", "Jimmy", "Tudisca", "Telefe", 55, "masculino"));
		}

		/// <summary>
		/// Obtengo el ultimo id del ultimo elemento de la lista y se lo asigno al idStatic
		/// </summary>
		/// <returns></returns>
		internal static void GetLastId()
		{

			foreach (Persona persona in personaList)
			{
				idStatic = persona.Id;
			}
		}

		public override string ToString()
		{
			return "DNI: " + this.Dni + " Nombre: " + this.Nombre + " Apellido: " + this.Apellido +
					" Voto: " + this.Voto + " Edad: " + this.Edad + " Genero: " + this.Genero;
		}

		/// <summary>
		/// Verifico si el archivo del que se quieren cargar los datos exista, caso contrario cargo la lista de datos harcodeados
		/// y escribo el archivo necesario y obtengo el ultimo id.
		/// </summary>
		static public void VerificarArchivoPersona()
		{
			string type = typeof(Persona).FullName;
			string file_name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\" + "Deserialize" + $"{type}" + ".xml";

			if (!File.Exists(file_name))
			{
				CargarListaDesdeHardcodeo();

				archPersona.ListToXML(personaList);
			}
			else {
				personaList = archPersona.MappingXMLToList();
				GetLastId();
			}
		}

	}
}
