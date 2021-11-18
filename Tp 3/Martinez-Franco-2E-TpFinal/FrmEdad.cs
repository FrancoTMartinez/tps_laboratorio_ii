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
	public partial class FrmEdad : Form
	{
		public int edad;
		public FrmEdad()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			int.TryParse(this.txtEdad.Text, out edad);

			if (Validar.Edades(edad))
			{
				this.DialogResult =DialogResult.OK;
			}
			else {
				this.lblErrorEdad.ForeColor = Color.Red;
				this.lblErrorEdad.Text = "Edad Invalida.\nDebe ser mayo a 17 anios.";
			}
		}

		private void txtEdad_TextChanged(object sender, EventArgs e)
		{

		}

		private void panelContenedor_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
