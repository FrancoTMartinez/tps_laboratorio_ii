using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;


namespace Entidades
{
	static public class Filtros
	{
		static int votosTotales;
		static int[] arrayVotosPorCanal;
		static float[] arrayPorcentajeVotos;
		static StringBuilder resultado;


		static Filtros()
		{
			resultado = new StringBuilder();

		}

		/// <summary>
		/// Calculo el porcentaje de votos totales por canal.
		/// </summary>
		/// <param name="personalist"></param>
		/// <param name="canalList"></param>
		/// <returns></returns>
		public static string PorcentajesTotalesPorCanal(List<Persona> personalist, List<Canal> canalList)
		{
			if (personalist.Count() == 0 || canalList.Count() == 0)
			{
				throw new Exception();
			}
			else {
				votosTotales = personalist.Count();
				arrayVotosPorCanal = new int[canalList.Count];
			}

			arrayPorcentajeVotos = new float[arrayVotosPorCanal.Length];
			resultado.Clear();
			

			foreach (Persona persona in personalist)
			{
				int x = 0;
				foreach (Canal canal in canalList)
				{
					if (persona.Voto == canal.Nombre)
					{
						arrayVotosPorCanal[x] += 1;
						break;
					}
					x++;
				}
			}

			SacarPorcentaje(arrayVotosPorCanal, arrayPorcentajeVotos, votosTotales);
	
			resultado.Append("Votos Totales Registrados: " + votosTotales);
			resultado.AppendLine();
			resultado.AppendLine();
			resultado.AppendLine(ObtenerResultados(arrayVotosPorCanal, arrayPorcentajeVotos, canalList));

			return resultado.ToString();

		}

		/// <summary>
		/// Calculo el porcentaje de votos totales filtrados por un genero que recibo por parametro.
		/// </summary>
		/// <param name="personalist"></param>
		/// <param name="canalList"></param>
		/// <param name="genero"></param>
		/// <returns></returns>
		public static string PorcentajesTotalesPorCanalFiltradoPorGenero(List<Persona> personalist, List<Canal> canalList, string genero)
		{
			if (genero == null) {
				throw new NullReferenceException();
			} else if (genero == string.Empty) {
				throw new Exception();
			}

			if (personalist.Count() == 0 || canalList.Count() == 0)
			{
				throw new Exception();
			}
			else
			{
				votosTotales = 0;
				arrayVotosPorCanal = new int[canalList.Count];
				arrayPorcentajeVotos = new float[arrayVotosPorCanal.Length];
				resultado.Clear();
			}
			

			foreach (Persona persona in personalist)
			{
				int x = 0;
				foreach (Canal canal in canalList)
				{
					if (persona.Voto == canal.Nombre && persona.Genero == genero)
					{
						arrayVotosPorCanal[x] += 1;
						votosTotales += 1;
						break;
					}
					x++;
				}
			}

			
			SacarPorcentaje(arrayVotosPorCanal, arrayPorcentajeVotos, votosTotales);
			
			resultado.Append($"Votos Totales Registrados Filtrados por {genero} : " + votosTotales);
			resultado.AppendLine();
			resultado.AppendLine();

			if (votosTotales > 0)
			{
				resultado.AppendLine(ObtenerResultados(arrayVotosPorCanal, arrayPorcentajeVotos, canalList));
				return resultado.ToString();
			}
			else {
				return "No re segistraron personas con ese genero.";
			}
		}

		/// <summary>
		/// Calculo el porcentaje de votos totales filtrados por una edad especifica que recibo por parametro.
		/// </summary>
		/// <param name="personalist"></param>
		/// <param name="canalList"></param>
		/// <param name="edad"></param>
		/// <returns></returns>
		public static string PorcentajesTotalesPorCanalFiltradoPorEdadEspecifica(List<Persona> personalist, List<Canal> canalList, int edad)
		{
			votosTotales = 0;
			arrayVotosPorCanal = new int[canalList.Count];
			arrayPorcentajeVotos = new float[arrayVotosPorCanal.Length];
			resultado.Clear();

			foreach (Persona persona in personalist)
			{
				int x = 0;
				foreach (Canal canal in canalList)
				{
					if (persona.Voto == canal.Nombre && persona.Edad == edad)
					{
						arrayVotosPorCanal[x] += 1;
						votosTotales += 1;
						break;
					}
					x++;
				}
			}


			SacarPorcentaje(arrayVotosPorCanal, arrayPorcentajeVotos, votosTotales);
			
			resultado.Append($"Votos Totales Registrados Filtrados por {edad} anios: " + votosTotales);
			resultado.AppendLine(); 
			resultado.AppendLine();

			if (votosTotales > 0)
			{
				resultado.AppendLine(ObtenerResultados(arrayVotosPorCanal, arrayPorcentajeVotos, canalList));
				return resultado.ToString();
			}
			else {
				return "No se registraron votos con esa edad.";
			}	
		}

		/// <summary>
		///  Calculo el porcentaje de votos totales filtrados por un rango etario que recibo por parametro.
		/// </summary>
		/// <param name="personalist"></param>
		/// <param name="canalList"></param>
		/// <param name="edadMin"></param>
		/// <param name="edadMax"></param>
		/// <returns></returns>
		public static string PorcentajesTotalesPorCanalFiltradoPorRangoEtario(List<Persona> personalist, List<Canal> canalList, int edadMin, int edadMax)
		{
			votosTotales = 0;
			arrayVotosPorCanal = new int[canalList.Count];
			arrayPorcentajeVotos = new float[arrayVotosPorCanal.Length];
			resultado.Clear();

			foreach (Persona persona in personalist)
			{
				int x = 0;
				foreach (Canal canal in canalList)
				{
					if (persona.Voto == canal.Nombre && persona.Edad >= edadMin && persona.Edad<= edadMax)
					{
						arrayVotosPorCanal[x] += 1;
						votosTotales += 1;
						break;
					}
					x++;
				}
			}


			SacarPorcentaje(arrayVotosPorCanal, arrayPorcentajeVotos, votosTotales);
			
			resultado.AppendLine($"Votos Totales Registrados Filtrados desde {edadMin} anios a {edadMax} anios : " + votosTotales);
			resultado.AppendLine();
			resultado.AppendLine();

			if (votosTotales > 0)
			{
				resultado.Append(ObtenerResultados(arrayVotosPorCanal, arrayPorcentajeVotos, canalList));
				return resultado.ToString();
			}
			else
			{
				return "No se registraron votos con ese rango etario.";
			}

			
		}

		/// <summary>
		///  Calculo el porcentaje de votos totales y solo muestro el canal que recibo por parametro.
		/// </summary>
		/// <param name="personalist"></param>
		/// <param name="canalList"></param>
		/// <param name="canalAFiltrar"></param>
		/// <returns></returns>
		public static string PorcentajesTotalesPorUnSoloCanal(List<Persona> personalist, List<Canal> canalList, string canalAFiltrar)
		{
			votosTotales = personalist.Count(); ;
			arrayVotosPorCanal = new int[canalList.Count];
			arrayPorcentajeVotos = new float[arrayVotosPorCanal.Length];
			resultado.Clear();
			bool flag = true ;

			foreach (Persona persona in personalist)
			{
				int x = 0;
				foreach (Canal canal in canalList)
				{
					if (persona.Voto == canal.Nombre && canal.Nombre == canalAFiltrar)
					{
						arrayVotosPorCanal[x] += 1;
						break;
					}
					x++;
				}
			}


			SacarPorcentaje(arrayVotosPorCanal, arrayPorcentajeVotos, votosTotales);
			
			resultado.Append($"Votos Totales Registrados: " + votosTotales );
			resultado.AppendLine();
			resultado.AppendLine();

			if (votosTotales > 0)
			{
				for (int i = 0; i < arrayPorcentajeVotos.Length; i++)
				{
					if (arrayPorcentajeVotos[i] !=0) {

						resultado.AppendLine(canalList.ElementAt(i).Nombre + ": " + arrayPorcentajeVotos[i].ToString() + " %" + "(" + arrayVotosPorCanal[i].ToString() + " votos)");
						flag = false;
					}
				}
			}

			if(flag){
				return $"No se registraron votos en el Canal {canalAFiltrar}.";
			}

			return resultado.ToString();
		}


		/// <summary>
		/// Calculo el porcentaje de votos totales
		/// </summary>
		/// <param name="arrayVotosPorCanal"></param>
		/// <param name="arrayPorcentajeVotos"></param>
		/// <param name="votosTotales"></param>
		internal static void SacarPorcentaje(int[] arrayVotosPorCanal, float[] arrayPorcentajeVotos ,int votosTotales)
		{
			for (int i = 0; i < arrayVotosPorCanal.Length; i++)
			{
				arrayPorcentajeVotos[i] = ((float)arrayVotosPorCanal[i] / (float)votosTotales) * 100;
			}
		}

		/// <summary>
		/// Genero el strig con los resultados totales de los votos.
		/// </summary>
		/// <param name="arrayVotosPorCanal"></param>
		/// <param name="arrayPorcentajeVotos"></param>
		/// <param name="canalList"></param>
		/// <returns></returns>
		static internal string ObtenerResultados(int[] arrayVotosPorCanal, float[] arrayPorcentajeVotos, List<Canal> canalList)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < arrayPorcentajeVotos.Length; i++)
			{
				sb.Append(canalList.ElementAt(i).Nombre + ": " + arrayPorcentajeVotos[i].ToString() + " %" + "(" + arrayVotosPorCanal[i].ToString() + " votos)\n");
			}

			return sb.ToString();
		}

	}
}
