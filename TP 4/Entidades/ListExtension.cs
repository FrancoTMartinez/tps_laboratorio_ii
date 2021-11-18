using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public static class ListExtension
	{
		/// <summary>
		/// Metodo de extencion de coleccion List, tomo por parametro un valor para edad y luego retorno una lista filtrada
		/// con esas edad
		/// </summary>
		/// <param name="personaList"></param>
		/// <param name="edad"></param>
		/// <returns></returns>
		public static List<Persona> FiltrarPorEdad(this List<Persona> personaList, int edad) {
			List<Persona> listaFiltrada = new List<Persona>();

			foreach (Persona persona in personaList)
			{
				if (persona.Edad == edad) {
					listaFiltrada.Add(persona);
				}
			}

			return listaFiltrada;
		}
	}
}
