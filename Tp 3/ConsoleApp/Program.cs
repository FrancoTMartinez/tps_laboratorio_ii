using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using Entidades;

namespace Test
{

	class Program
	{
		static void Main(string[] args)
		{
			string respuestaPorcentaje;
			bool respuesta;
			Archivos<string> archRespuesta = new Archivos<string>();

			try
			{
				Persona.VerificarArchivoPersona();
				List<Persona> personaLista = Persona.GetList();
				Canal.VerificarArchivoCanal();
				List<Canal> canalLista = Canal.GetList();
				Admin.VerificarArchivoAdmin();
				List<Admin> adminLista = Admin.GetList();

				if (personaLista != null)
				{
					Console.WriteLine("Lista de personas cargada con exito.");
					Console.WriteLine();
					Console.WriteLine("-------------------------------------------------------");
				}
				if (canalLista != null)
				{
					Console.WriteLine("Lista de canales cargada con exito.");
					Console.WriteLine();
					Console.WriteLine("-------------------------------------------------------");
				}
				if (adminLista != null)
				{
					Console.WriteLine("Lista de administradores cargada con exito.");
					Console.WriteLine();
					Console.WriteLine("-------------------------------------------------------");
				}

				respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorGenero(personaLista, canalLista, "masculino");

				Console.WriteLine(respuestaPorcentaje);
				Console.WriteLine();
				respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorGeneroMasculino", respuestaPorcentaje);
				if (respuesta)
				{
					Console.WriteLine("Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorGeneroMasculino.");
				}

				Console.WriteLine("-------------------------------------------------------");

				respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorGenero(personaLista, canalLista, "femenino");

				Console.WriteLine(respuestaPorcentaje);
				Console.WriteLine();
				respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorGeneroFemenino", respuestaPorcentaje);
				if (respuesta)
				{
					Console.WriteLine("Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorGeneroFemenino.");
				}
				Console.WriteLine("-------------------------------------------------------");

				respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorGenero(personaLista, canalLista, "no binario");

				Console.WriteLine(respuestaPorcentaje);
				Console.WriteLine();
				respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorGeneroNoBinario", respuestaPorcentaje);
				if (respuesta)
				{
					Console.WriteLine("Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorGeneroNoBinario.");
				}
				Console.WriteLine("-------------------------------------------------------");

				respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorEdadEspecifica(personaLista, canalLista, 21);

				Console.WriteLine(respuestaPorcentaje);
				Console.WriteLine();
				respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorEdadEspecifica", respuestaPorcentaje);
				if (respuesta)
				{
					Console.WriteLine("Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorEdadEspecifica.");
				}
				Console.WriteLine("-------------------------------------------------------");

				respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorRangoEtario(personaLista, canalLista, 21, 32);

				Console.WriteLine(respuestaPorcentaje);
				Console.WriteLine();
				respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorRangoEtario", respuestaPorcentaje);
				if (respuesta)
				{
					Console.WriteLine("Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorRangoEtario.");
				}
				Console.WriteLine("-------------------------------------------------------");

				respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanal(personaLista, canalLista);

				Console.WriteLine(respuestaPorcentaje);
				Console.WriteLine();
				respuesta = archRespuesta.ExportarRespuestas("ResultadosTotales", respuestaPorcentaje);
				if (respuesta)
				{
					Console.WriteLine("Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosTotales.");
				}
				Console.WriteLine("-------------------------------------------------------");

				respuestaPorcentaje = Filtros.PorcentajesTotalesPorUnSoloCanal(personaLista, canalLista, "Telefe");

				Console.WriteLine(respuestaPorcentaje);
				Console.WriteLine();
				respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorUnSoloCanal", respuestaPorcentaje);
				if (respuesta)
				{
					Console.WriteLine("Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorUnSoloCanal.");
				}
				Console.WriteLine("-------------------------------------------------------");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Hubo un error: " + ex.Message);
			}


		}
	}
}
