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
	public partial class FrmRangoEtario : Form
	{
		public FrmRangoEtario()
		{
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			int edadMin =0;
			int edadMax=0;

			if (int.TryParse(this.cmBoxEdadMin.SelectedItem.ToString(), out edadMin) && Validar.Edades(edadMin))
			{
				if (int.TryParse(this.cmBoxEdadMax.SelectedItem.ToString(), out edadMax) && Validar.Edades(edadMax))
				{
					if (Validar.Edades(edadMin, edadMax))
					{
						this.DialogResult = DialogResult.OK;
					}
					else
					{
						this.lblErrorEdadMax.ForeColor = Color.Red;
						this.lblErrorEdadMax.Text = "La Edad min no puede ser mayor a la edad max.";
					}
				}
				else
				{
					this.lblErrorEdadMax.ForeColor = Color.Red;
					this.lblErrorEdadMax.Text = "Edad Invalida.";
					this.lblErrorEdadMin.Text = string.Empty;

				}
			}
			else
			{
				this.lblErrorEdadMin.ForeColor = Color.Red;
				this.lblErrorEdadMin.Text = "Edad Invalida.";
				
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
