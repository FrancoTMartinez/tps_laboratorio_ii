using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Martinez_Franco_2E_TpFinal
{
	public partial class FrmResultados : Form
	{
		private List<Persona> personaLista;
		private List<Canal> canalLista;
		Archivos<string> archRespuesta;
		string respuestaPorcentaje;
		bool respuesta;

		public FrmResultados()
		{
			InitializeComponent();
		}

		private void FrmResultados_Load(object sender, EventArgs e)
		{
			try
			{

				Persona.VerificarArchivoPersona();
				personaLista = Persona.GetList();

				Canal.VerificarArchivoCanal();
				canalLista = Canal.GetList();

				archRespuesta = new Archivos<string>();
				personalizarDisenio();

			}
			catch (Exception)
			{
				this.lblResultado.Text = "Ocurrio un error en la carga de datos.";
				ocultarSubMenu();
				DeshabilitarBotones();
				this.btnRecargarArchivos.Visible = true;
			}
			
		}

		private void DeshabilitarBotones() {
			this.btnGenero.Enabled = false;
			this.btnEdad.Enabled = false;
			this.btnCanal.Enabled = false;
		}

		private void ocultarSubMenu() {
			if (panelGenero.Visible==true) {
				panelGenero.Visible = false;
			}
			if (panelEdad.Visible==true) {
				panelEdad.Visible = false;
			}
			if (panelCanal.Visible==true) {
				panelCanal.Visible = false;
			}
		
		}

		private void MostrarSubMenu(Panel subMenu) {
			if (subMenu.Visible == false)
			{
				ocultarSubMenu();
				subMenu.Visible = true;
			}
			else {
				subMenu.Visible = false;
			}
		}

		private void personalizarDisenio(){
			panelGenero.Visible = false;
			panelEdad.Visible = false;
			panelCanal.Visible = false;
		}

		private void btnGenero_Click(object sender, EventArgs e)
		{
			MostrarSubMenu(panelGenero);
		}

		private void btnMasculino_Click(object sender, EventArgs e)
		{
			

			respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorGenero(personaLista,canalLista,"masculino");
			respuesta= archRespuesta.ExportarRespuestas("ResultadosFiltradoPorGeneroMasculino", respuestaPorcentaje);

			if (respuesta) {
				this.lblResultado.Text = respuestaPorcentaje;
				this.lblInforme.Text = "Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorGeneroMasculino.";
			}
			ocultarSubMenu();
		}

		private void btnFemenino_Click(object sender, EventArgs e)
		{
			respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorGenero(personaLista, canalLista, "femenino");
			respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorGeneroFemenino", respuestaPorcentaje);

			if (respuesta)
			{
				this.lblResultado.Text = respuestaPorcentaje;
				this.lblInforme.Text = "Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorGeneroFemenino.";
			}
			ocultarSubMenu();
		}

		private void btnNoBinario_Click(object sender, EventArgs e)
		{
			respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorGenero(personaLista, canalLista, "no binario");
			respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorGeneroNoBinario", respuestaPorcentaje);

			if (respuesta)
			{
				this.lblResultado.Text = respuestaPorcentaje;
				this.lblInforme.Text = "Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorGeneroNoBinario.";
			}
			ocultarSubMenu();
		}

		private void btnEdad_Click(object sender, EventArgs e)
		{
			MostrarSubMenu(panelEdad);
		}


		private void btnEdadEspecifica_Click(object sender, EventArgs e)
		{
			FrmEdad frmEdad = new FrmEdad();

			if (frmEdad.ShowDialog() == DialogResult.OK) {
				string edadStr = frmEdad.txtEdad.Text;
				int edad;
				int.TryParse(edadStr, out edad);

				respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorEdadEspecifica(personaLista, canalLista, edad);
				respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorEdadEspecifica", respuestaPorcentaje);

				if (respuesta)
				{
					this.lblResultado.Text = respuestaPorcentaje;
					this.lblInforme.Text = "Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorEdadEspecifica.";
				}

			}
			ocultarSubMenu();
		}

		private void btnRangoEtario_Click(object sender, EventArgs e)
		{
			FrmRangoEtario frmRangoEtario = new FrmRangoEtario();

			if (frmRangoEtario.ShowDialog() == DialogResult.OK)
			{
				string edadMinStr = frmRangoEtario.cmBoxEdadMin.SelectedItem.ToString();
				string edadMaxStr = frmRangoEtario.cmBoxEdadMax.SelectedItem.ToString();

				int edadMin;
				int edadMax;
				int.TryParse(edadMinStr, out edadMin);
				int.TryParse(edadMaxStr, out edadMax);

				respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanalFiltradoPorRangoEtario(personaLista, canalLista, edadMin,edadMax);
				respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorRangoEtario", respuestaPorcentaje);

				if (respuesta)
				{
					this.lblResultado.Text = respuestaPorcentaje;
					this.lblInforme.Text = "Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorRangoEtario.";
				}
			}
			ocultarSubMenu();
		}

		private void btnCanal_Click(object sender, EventArgs e)
		{
			MostrarSubMenu(panelCanal);
		}

		private void btnTodos_Click(object sender, EventArgs e)
		{
			respuestaPorcentaje = Filtros.PorcentajesTotalesPorCanal(personaLista, canalLista);
			respuesta = archRespuesta.ExportarRespuestas("ResultadosTotales", respuestaPorcentaje);

			if (respuesta)
			{
				this.lblResultado.Text = respuestaPorcentaje;
				this.lblInforme.Text = "Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosTotales.";
			}
			ocultarSubMenu();
		}

		private void btnUnSoloCanal_Click(object sender, EventArgs e)
		{

			FrmElegirCanal frmElegirCanal = new FrmElegirCanal();
			string resultadoCanal = string.Empty;

			if (frmElegirCanal.ShowDialog() == DialogResult.OK)
			{
				resultadoCanal = frmElegirCanal.votoCanal;
				respuestaPorcentaje = Filtros.PorcentajesTotalesPorUnSoloCanal(personaLista, canalLista, resultadoCanal);
				respuesta = archRespuesta.ExportarRespuestas("ResultadosFiltradoPorUnSoloCanal", respuestaPorcentaje);

				if (respuesta)
				{
					this.lblResultado.Text = respuestaPorcentaje;
					this.lblInforme.Text = "Resultados guardados en el archivo: Archivos\\Resultado\\ResultadosFiltradoPorUnSoloCanal.";
				}

				ocultarSubMenu();
			}
		}

		private void btnRecargarArchivos_Click(object sender, EventArgs e)
		{
			try
			{
				Persona.CargarListaDesdeArchivo();
				FrmResultados_Load(sender, e);
			}
			catch (Exception ex)
			{
				this.lblResultado.Text = ex.Message;

			}

		}
	}
}
