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

namespace MiCalculadora
{
	public partial class FormCalculadora : Form
	{
		public FormCalculadora()
		{
			InitializeComponent();
		}

		private void OperarNumeros(object sender, EventArgs e)
		{
			Operando numero1 = new Operando(this.txtNumero1.Text);
			Operando numero2 = new Operando(this.txtNumero2.Text);

			if (this.cmbBoxOperando.SelectedIndex != 0)
			{

				char.TryParse(this.cmbBoxOperando.Text, out char operador);
				double resultado = Calculadora.Operar(numero1, numero2, operador);

				StringBuilder historial = new StringBuilder();
				historial.AppendLine(this.txtNumero1.Text);
				historial.AppendLine(operador.ToString());
				historial.AppendLine(this.txtNumero2.Text);
				historial.AppendLine("=" + resultado.ToString());

				this.listBoxHistorial.Items.Add(historial.ToString());
				this.lblResultado.Text = resultado.ToString();
			}
			else {
				MessageBox.Show("Debe seleccionar un operando.", "Calculadora",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void Limpiar(object sender, EventArgs e)
		{
			this.txtNumero1.Text = "";
			this.txtNumero2.Text = "";
			this.cmbBoxOperando.SelectedIndex = 0;
			this.lblResultado.Text = "";
		}

		private void Cerrar(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Estas seguro que desea cerrar?", "Calculadora",
									MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if (result == DialogResult.Yes)
			{
				e.Cancel = false;
			}
			else {
				e.Cancel = true;
			}
			
		}

		private void ConvertirABinario(object sender, EventArgs e)
		{
			StringBuilder historial = new StringBuilder();
			Operando numero = new Operando();
			
			double numeroAConvertir;
			string resultado;
			bool flag;
			flag= double.TryParse(this.lblResultado.Text, out numeroAConvertir);
				
			resultado= numero.DecimalBinario(Math.Abs(numeroAConvertir));
			if (resultado != "Valor Invalido" && !string.IsNullOrEmpty(this.lblResultado.Text) && flag) {
				if (string.IsNullOrEmpty(resultado))
				{
					resultado = "0";
				}

				historial.AppendLine(Math.Abs(numeroAConvertir).ToString() + "D" + "= " + resultado + "B");
				this.listBoxHistorial.Items.Add(historial.ToString());
				this.lblResultado.Text = resultado;
			}
			else
			{
				MessageBox.Show("Valor Invalido", "Calculadora", MessageBoxButtons.OK);
			}

		}

		private void ConvertirADecimal(object sender, EventArgs e)
		{
			Operando numero = new Operando();
			StringBuilder historial = new StringBuilder();

			string binario = this.lblResultado.Text;
			string resultado;

			resultado= numero.BinarioDecimal(binario);
			if (resultado != "Valor Invalido" && !string.IsNullOrEmpty(binario))
			{

				historial.AppendLine(this.lblResultado.Text + "B" + "= " + resultado + "D");
				this.listBoxHistorial.Items.Add(historial.ToString());
				this.lblResultado.Text = resultado;
			}
			else {
				MessageBox.Show(resultado,"Calculadora" ,MessageBoxButtons.OK);
			}
		}
	}
}
