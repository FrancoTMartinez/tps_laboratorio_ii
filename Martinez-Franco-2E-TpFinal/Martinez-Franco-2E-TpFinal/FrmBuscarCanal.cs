using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Martinez_Franco_2E_TpFinal
{
	public partial class FrmBuscarCanal : Form
	{

		Canal canal;
		public FrmBuscarCanal()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				Canal.VerificarArchivoCanal();
				canal = Canal.SearchByName(this.txtCanalABuscar.Text);
				if (canal == null)
				{
					this.lblInforme.ForeColor = Color.Red;
					this.lblInforme.Text = "El canal no se encontro.";
				}
				else
				{
					this.lblInforme.ForeColor = Color.Green;
					this.lblInforme.Text = "Canal Encontrado.";
				}
			}
			catch (Exception)
			{

				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = "Hubo un problema al acceder al archivo.";
			}

		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.txtCanalABuscar.Text != string.Empty)
				{
					canal.Nombre = this.txtCanalABuscar.Text;
					canal.UpdateFromList(canal);
					this.lblInforme.ForeColor = Color.Green;
					this.lblInforme.Text = "El nombre del canal fue modificado Exitosamente.";
				}
				else
				{
					this.lblInforme.ForeColor = Color.Red;
					this.lblInforme.Text = "Debe ingresar un texto.";
				}
			}
			catch (Exception)
			{

				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = "Hubo un problema al querer ingresar al archivo.";
			}

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.txtCanalABuscar.Text != string.Empty)
				{
					canal.DeleteFromList(canal.Id);
					this.lblInforme.ForeColor = Color.Green;
					this.lblInforme.Text = "Canal eliminado Exitosamente.";
				}
				else
				{
					this.lblInforme.ForeColor = Color.Red;
					this.lblInforme.Text = "Debe ingresar un texto.";
				}
			} catch (Exception) {
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = "Hubo un problema al querer ingresar al archivo.";
			}

		}
	}
}
