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
	public partial class frmMain : Form
	{

		public frmMain()
		{
			InitializeComponent();
		}

		private void btnResultados_Click(object sender, EventArgs e)
		{
			FrmResultados frmRessultado = new FrmResultados();
			if (frmRessultado.ShowDialog()== DialogResult.OK) {
			
			}
		}

		private void btnVotar_Click(object sender, EventArgs e)
		{
			FrmVoto frmVoto = new FrmVoto();

			if (frmVoto.ShowDialog() == DialogResult.OK) {
			
			}
		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{
			try
			{
				FrmLogIn frmLogIn = new FrmLogIn();
				if (frmLogIn.ShowDialog() == DialogResult.OK)
				{

				}
			}
			catch (Exception)
			{

				throw;
			}

		}
	}
}
