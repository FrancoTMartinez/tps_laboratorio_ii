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
	public partial class FrmModificar : Form
	{
		public Persona persona;

		public FrmModificar()
		{
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				Validar.ValidarDNI(this.txtDNI.Text);

				persona = Persona.SearchByDNI(this.txtDNI.Text);

				if (persona != null)
				{
					this.DialogResult = DialogResult.OK;
				}
				else
				{
					this.lblError.Visible = true;
					this.lblError.Text = "Dni no encontrado";
				}
			}
			catch (Exception)
			{
				this.lblError.Visible = true;
				this.lblError.Text = "Hubo un problema al cargar el archivo.\nVerifique que el mismo exista.";
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
