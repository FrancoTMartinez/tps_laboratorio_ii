using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entidades
{
	static public class Filtros
	{
		static int votosTotales;
		static int[] arrayVotosPorCanal;
		static float[] arrayPorcentajeVotos;
		static StringBuilder resultado;
		static ConnectionDB connectionDB;

		static Filtros()
		{
			resultado = new StringBuilder();
			connectionDB = new ConnectionDB();

		}
		/// <summary>
		/// Calculo el porcentaje de votos totales por canal.
		/// </summary>
		/// <returns></returns>
		public static string PorcentajesTotalesPorCanal()
		{
			try
			{
				string queryCantVotos = $"SELECT COUNT(TablePersonas.ID) AS 'VotosTotales' FROM TablePersonas";
				string queryVotosPorCanal = $"SELECT COUNT(TablePersonas.IDCanal) as 'CantVotos', TableCanales.Nombre from TablePersonas " +
													$"JOIN TableCanales on TablePersonas.IDCanal = TableCanales.ID " +
													$"GROUP BY TableCanales.Nombre ORDER BY 'CantVotos' DESC";
				GetVotosTotales(queryCantVotos);
				GetVotosPorCanal(queryVotosPorCanal);

				arrayPorcentajeVotos = new float[arrayVotosPorCanal.Length];
				resultado.Clear();

				SacarPorcentaje(arrayVotosPorCanal, arrayPorcentajeVotos, votosTotales);

				resultado.Append("Votos Totales Registrados: " + votosTotales);
				resultado.AppendLine();
				resultado.AppendLine();
				resultado.AppendLine(ObtenerResultados(arrayVotosPorCanal, arrayPorcentajeVotos));

				return resultado.ToString();
			}
			catch (Exception)
			{

				throw;
			}
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
			if (genero == null)
			{
				throw new NullReferenceException();
			}
			else if (genero == string.Empty)
			{
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
					if (Canal.GetNameById(persona.IdCanal) == canal.Nombre && persona.Genero == genero)
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
				resultado.AppendLine(ObtenerResultados(arrayVotosPorCanal, arrayPorcentajeVotos));
				return resultado.ToString();
			}
			else
			{
				return "No re segistraron personas con ese genero.";
			}
		}

		/// <summary>
		/// Calculo el porcentaje de votos totales filtrados por una edad especifica que recibo por parametro.
		/// </summary>
		/// <param name="personalist"></param>
		/// <param name="canalList"></param>
		/// <param name="edadAFiltrar"></param>
		/// <returns></returns>
		public static string PorcentajesTotalesPorCanalFiltradoPorEdadEspecifica(List<Persona> personalist, List<Canal> canalList, int edadAFiltrar)
		{
			try
			{
				votosTotales = personalist.FiltrarPorEdad(edadAFiltrar).Count;
				arrayVotosPorCanal = new int[canalList.Count];
				arrayPorcentajeVotos = new float[arrayVotosPorCanal.Length];
				resultado.Clear();

				personalist.ForEach(persona =>
				{
					int x = 0;
					canalList.ForEach(canal =>
					{
						if (Canal.GetNameById(persona.IdCanal) == canal.Nombre && persona.Edad == edadAFiltrar)
						{
							arrayVotosPorCanal[x] += 1;
						}
						x++;
					});
				});

				SacarPorcentaje(arrayVotosPorCanal, arrayPorcentajeVotos, votosTotales);

				resultado.Append($"Votos Totales Registrados Filtrados por {edadAFiltrar} anios: " + votosTotales);
				resultado.AppendLine();
				resultado.AppendLine();

				if (votosTotales > 0)
				{
					resultado.AppendLine(ObtenerResultados(arrayVotosPorCanal, arrayPorcentajeVotos));
					return resultado.ToString();
				}
				else
				{
					return "No se registraron votos con esa edad.";
				}

			}
			catch (Exception)
			{

				throw;
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

			personalist.ForEach(persona =>
			{
				int x = 0;
				canalList.ForEach(canal =>
				{
					if (Canal.GetNameById(persona.IdCanal) == canal.Nombre && persona.Edad >= edadMin && persona.Edad <= edadMax)
					{
						arrayVotosPorCanal[x] += 1;
						votosTotales += 1;
					}
					x++;
				});
			});


			SacarPorcentaje(arrayVotosPorCanal, arrayPorcentajeVotos, votosTotales);

			resultado.AppendLine($"Votos Totales Registrados Filtrados desde {edadMin} anios a {edadMax} anios : " + votosTotales);
			resultado.AppendLine();
			resultado.AppendLine();

			if (votosTotales > 0)
			{
				resultado.Append(ObtenerResultados(arrayVotosPorCanal, arrayPorcentajeVotos));
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
		/// <param name="canalAFiltrar"></param>
		/// <returns></returns>
		public static string PorcentajesTotalesPorUnSoloCanal(string canalAFiltrar)
		{
			try
			{
				bool flag = true;
				string queryCantVotos = $"SELECT COUNT(TablePersonas.ID) AS 'VotosTotales' FROM TablePersonas";
				string queryVotosPorCanal = $"SELECT COUNT(TablePersonas.IDCanal) AS 'CantVotos', TableCanales.Nombre FROM TablePersonas " +
					$"JOIN TableCanales ON TablePersonas.IDCanal = TableCanales.ID AND TableCanales.Nombre = '{canalAFiltrar}' " +
					$"GROUP BY TableCanales.Nombre";

				GetVotosTotales(queryCantVotos);
				GetVotosPorCanal(queryVotosPorCanal);

				arrayPorcentajeVotos = new float[arrayVotosPorCanal.Length];
				resultado.Clear();

				SacarPorcentaje(arrayVotosPorCanal, arrayPorcentajeVotos, votosTotales);

				resultado.Append($"Votos Totales Registrados: " + votosTotales);
				resultado.AppendLine();
				resultado.AppendLine();

				if (votosTotales > 0)
				{
					for (int i = 0; i < arrayPorcentajeVotos.Length; i++)
					{
						if (arrayPorcentajeVotos[i] != 0)
						{

							resultado.AppendLine(canalAFiltrar + ": " + arrayPorcentajeVotos[i].ToString() + " %" + "(" + arrayVotosPorCanal[i].ToString() + " votos)");
							flag = false;
						}
					}
				}

				if (flag)
				{
					return $"No se registraron votos en el Canal {canalAFiltrar}.";
				}

				return resultado.ToString();
			}
			catch (Exception)
			{

				throw;
			}
		}


		/// <summary>
		/// Calculo el porcentaje de votos totales
		/// </summary>
		/// <param name="arrayVotosPorCanal"></param>
		/// <param name="arrayPorcentajeVotos"></param>
		/// <param name="votosTotales"></param>
		internal static void SacarPorcentaje(int[] arrayVotosPorCanal, float[] arrayPorcentajeVotos, int votosTotales)
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
		static internal string ObtenerResultados(int[] arrayVotosPorCanal, float[] arrayPorcentajeVotos)
		{
			StringBuilder sb = new StringBuilder();
			List<Canal> canalList = Canal.GetList();
			for (int i = 0; i < arrayPorcentajeVotos.Length; i++)
			{
				sb.Append(canalList.ElementAt(i).Nombre + ": " + arrayPorcentajeVotos[i].ToString() + " %" + "(" + arrayVotosPorCanal[i].ToString() + " votos)\n");
			}

			return sb.ToString();
		}


		/// <summary>
		/// Obtengo el valor de la cantidad todal de votos directamente de la base de datos
		/// </summary>
		/// <param name="queryCantVotos"></param>
		static internal void GetVotosTotales(string queryCantVotos)
		{
			try
			{
				connectionDB.Command.CommandText = queryCantVotos;
				connectionDB.Command.Parameters.Clear();

				if (connectionDB.Connection.State != ConnectionState.Open)
				{
					connectionDB.Connection.Open();
				}

				connectionDB.Reader = connectionDB.Command.ExecuteReader();

				while (connectionDB.Reader.Read())
				{
					votosTotales = int.Parse(connectionDB.Reader["VotosTotales"].ToString());
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

		}

		/// <summary>
		/// Obtengo los votos por canal directamente de la base de datos
		/// </summary>
		/// <param name="queryVotosPorCanal"></param>
		static internal void GetVotosPorCanal(string queryVotosPorCanal)
		{
			try
			{
				if (connectionDB.Connection.State != ConnectionState.Open)
				{
					connectionDB.Connection.Open();
				}

				connectionDB.Command.CommandText = $"SELECT COUNT(TableCanales.ID) AS 'CanalesTotales' FROM TableCanales";

				connectionDB.Reader = connectionDB.Command.ExecuteReader();
				while (connectionDB.Reader.Read())
				{
					arrayVotosPorCanal = new int[int.Parse(connectionDB.Reader["CanalesTotales"].ToString())];

				}

				connectionDB.Reader.Close();

				connectionDB.Command.CommandText = queryVotosPorCanal;


				connectionDB.Reader = connectionDB.Command.ExecuteReader();

				int i = 0;
				while (connectionDB.Reader.Read())
				{
					arrayVotosPorCanal[i] = int.Parse(connectionDB.Reader["CantVotos"].ToString());
					i++;
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

		}

	}
}
