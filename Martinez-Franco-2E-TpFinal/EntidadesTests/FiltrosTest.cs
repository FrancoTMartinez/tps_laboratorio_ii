using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Entidades;

namespace EntidadesTests
{
	[TestClass]
	public class FiltrosTest
	{
		List<Persona> personaLista;
		List<Canal> canalLista;

		[TestInitialize]
		public void initialize() {
			personaLista = new List<Persona>();
			canalLista = new List<Canal>();
		}

		[TestMethod]
		public void PorcentajesTotalesPorCanalShouldReturnString()
		{
			personaLista.Add(new Persona("42416954","Franco","Martinez","Space",21,"masculino"));
			canalLista.Add(new Canal("Space"));

			string respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanal(personaLista, canalLista);
			Assert.IsNotNull(respuestaPorcentaje);
			
		}

		[ExpectedException(typeof(Exception))]
		[TestMethod]
		public void PorcentajesTotalesPorCanalShouldReturnExeption()
		{
			string respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanal(personaLista, canalLista);
		}

		[TestMethod]
		public void PorcentajesTotalesPorCanalFiltradoPorGeneroShouldReturnString(){

			personaLista.Add(new Persona("42416954", "Franco", "Martinez", "Space", 21, "masculino"));
			canalLista.Add(new Canal("Space"));

			string respustaPorcentaje= Filtros.PorcentajesTotalesPorCanalFiltradoPorGenero(personaLista, canalLista,"masculino");
			Assert.IsNotNull(respustaPorcentaje);
		}

		[ExpectedException(typeof(NullReferenceException))]
		[TestMethod]
		public void PorcentajesTotalesPorCanalFiltradoPorGeneroShouldReturnNullReferenceException()
		{
			string respustaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorGenero(personaLista, canalLista, null);

		}

		[ExpectedException(typeof(Exception))]
		[TestMethod]
		public void PorcentajesTotalesPorCanalFiltradoPorGeneroShouldReturnException()
		{
			string respustaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorGenero(personaLista, canalLista, "masculino");

		}
	}
}
