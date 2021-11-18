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
			string respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanal();
			Assert.IsNotNull(respuestaPorcentaje);
			
		}
		
		[TestMethod]
		public void PorcentajesTotalesPorCanalFiltradoPorGeneroShouldReturnString(){

			personaLista.Add(new Persona("42416954", "Franco", "Martinez", 7, 21, "masculino"));
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
