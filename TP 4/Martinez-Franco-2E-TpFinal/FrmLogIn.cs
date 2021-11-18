using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Martinez_Franco_2E_TpFinal
{
	public partial class FrmLogIn : Form
	{
		public FrmLogIn()
		{
			InitializeComponent();

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (Validar.ValidateAdmin(this.txtUsuario.Text, this.txtPassword.Text))
				{
					FrmAdmin frmAdmin = new FrmAdmin();
					this.Hide();
					if (frmAdmin.ShowDialog() == DialogResult.OK)
					{

					}
				}
				else {
					this.lblInforme.ForeColor = Color.Red;
					this.lblInforme.Text = "Credenciales incorrectas.";
				}
			}
			catch (Exception)
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = "Ocurrio un error al querer acceder al archivo.";
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
