using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Martinez_Franco_2E_TpFinal
{
	public partial class FrmAdmin : Form
	{
		public FrmAdmin()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnExportarAdmins_Click(object sender, EventArgs e)
		{
			try
			{
				List<Admin> adminList = Admin.GetList();
				Archivos<Admin> adminArch = new Archivos<Admin>();

				adminArch.SerializingList(adminList);

				this.lblInforme.ForeColor = Color.Green;
				this.lblInforme.Text = "Archivo generado correctamente.";

				Console.Beep();
			}
			catch (Exception)
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = "No se pudo generar el archivo.";
			}

		}

		private void btnBuscarCanal_Click(object sender, EventArgs e)
		{
			FrmBuscarCanal frmBuscarCanal = new FrmBuscarCanal();
			if (frmBuscarCanal.ShowDialog() == DialogResult.OK)
			{

			}
		}

		private void btnAgregarCanal_Click(object sender, EventArgs e)
		{
			try
			{
				Canal.VerificarArchivoCanal();
				if (this.txtCanalNuevo.Text != string.Empty && Validar.ValidarCadenaTextoConNumeros(this.txtCanalNuevo.Text) && Validar.ValidateExistingCanal(this.txtCanalNuevo.Text))
				{
					Canal nuevoCanal = new Canal(this.txtCanalNuevo.Text);
					nuevoCanal.AddToList(nuevoCanal);
					this.lblInforme.ForeColor = Color.Green;
					this.lblInforme.Text = "Canal agregado correctamente.";
					Console.Beep();
				}
				else
				{
					this.lblInforme.ForeColor = Color.Red;
					this.lblInforme.Text = "Nombre del canal invalido.";
				}
			}
			catch (Exception)
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = "Hubo un problema al querer acceder al archivo.";
			}


		}

		private void btnAdminABM_Click(object sender, EventArgs e)
		{
			FrmAdministradoresABM_ frmAdministradoresABM_ = new FrmAdministradoresABM_();
			if (frmAdministradoresABM_.ShowDialog() == DialogResult.OK)
			{

			}
		}
	}
}
