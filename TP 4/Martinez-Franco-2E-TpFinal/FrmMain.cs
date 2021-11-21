using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Franco_2E_TpFinal
{
	public partial class frmMain : Form
	{
		public frmMain()
		{

			InitializeComponent();

			Task.Run(() => PersonasNecesarias());
			Thread.Sleep(2000);

		}

		/// <summary>
		/// Dispara el evento para habilitar o deshabilitar el boton ¨Resutlado¨
		/// </summary>
		private void PersonasNecesarias()
		{
			while (true)
			{
				Persona persona = new Persona();
				persona.CantPersonasNecesarias += HabilitarBotonEvent;
				Thread.Sleep(1000);
				persona.ContarPersonas();

			}
		}


		/// <summary>
		/// Es aquel que controla la habilitacion del boton y la aparicion del label con la cantidad de votos faltantes.
		/// </summary>
		/// <param name="personaList"></param>
		private void HabilitarBotonEvent(List<Persona> personaList)
		{
			if (personaList.Count >= 40)
			{
				if (this.btnResultados.InvokeRequired && this.lblResultado.InvokeRequired)
				{
					this.btnResultados.BeginInvoke((MethodInvoker)delegate ()
					{
						this.lblResultado.BeginInvoke((MethodInvoker)delegate ()
						{
							this.lblResultado.Visible = false;

						});

						this.btnResultados.Enabled = true;

					});
				}
				else
				{
					this.btnResultados.Enabled = true;
					this.lblResultado.Visible = false;
				}

			}
			else
			{
				if (this.btnResultados.InvokeRequired && this.lblResultado.InvokeRequired)
				{
					this.btnResultados.BeginInvoke((MethodInvoker)delegate ()
					{
						this.lblResultado.BeginInvoke((MethodInvoker)delegate ()
						{
							this.lblResultado.Text = $"Votos restantes para acceder a las respuestas: {40 - personaList.Count }";
							this.lblResultado.Visible = true;

						});

						this.btnResultados.Enabled = false;
					});
				}
				else
				{
					this.btnResultados.Enabled = false;
					this.lblResultado.Text = $"Votos restantes para acceder a las respuestas: {40 - personaList.Count }";
					this.lblResultado.Visible = true;
				}
			}
		}


		private void btnResultados_Click(object sender, EventArgs e)
		{
			if (this.btnResultados.Enabled)
			{
				FrmResultados frmRessultado = new FrmResultados();
				if (frmRessultado.ShowDialog() == DialogResult.OK)
				{

				}
			}

		}

		private void btnVotar_Click(object sender, EventArgs e)
		{
			FrmVoto frmVoto = new FrmVoto();

			if (frmVoto.ShowDialog() == DialogResult.OK)
			{

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
