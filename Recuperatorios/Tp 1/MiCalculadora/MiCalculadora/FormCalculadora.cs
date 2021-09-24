using Entidades;
using System;
using System.Text;
using System.Windows.Forms;

namespace MiCalculadora
{
	public partial class FormCalculadora : Form
	{
		public FormCalculadora()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Cuando se dispara el evento se realiza una validacion sobre el comboBox el cual debe estar
		/// seleccionando un operador, caso contrario saldra un alerta para informar al usuario del error.
		/// Una vez validado el comboBox se llamaran a los metodos correspondientes para realizar la operacion,
		/// una vez hecha el resultado se mostrara en el Label y a su vez la operacion quedara registrada
		/// en el ListBox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OperarNumeros(object sender, EventArgs e)
		{
			Operando numero1 = new Operando(this.txtNumero1.Text);
			Operando numero2 = new Operando(this.txtNumero2.Text);



			char.TryParse(this.cmbBoxOperando.Text, out char operador);
			double resultado = Calculadora.Operar(numero1, numero2, operador);

			StringBuilder historial = new StringBuilder();
			historial.AppendLine(this.txtNumero1.Text);
			if (operador == '\0') {
				operador = '+';
			}
			historial.AppendLine(operador.ToString());
			historial.AppendLine(this.txtNumero2.Text);
			historial.AppendLine("=" + resultado.ToString());

			this.listBoxHistorial.Items.Add(historial.ToString());
			this.lblResultado.Text = resultado.ToString();



		}

		/// <summary>
		/// Este evento ¨limpiara¨ los textBox y el Label setteando sus valores a ¨ ¨ en caso de los 
		/// textBox y el label, en el caso del ComboBox se seleccionara el item de la posicion cero.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Limpiar(object sender, EventArgs e)
		{
			this.txtNumero1.Text = "";
			this.txtNumero2.Text = "";
			this.cmbBoxOperando.SelectedIndex = 0;
			this.lblResultado.Text = "";
		}

		/// <summary>
		/// Este evento cerrara la calculadora
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Cerrar(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Este evento cerra la calculdora previamente lanzar un confirmacion.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Estas seguro que desea cerrar?", "Calculadora",
									MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if (result == DialogResult.Yes)
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = true;
			}

		}

		/// <summary>
		/// Este evento convertira el numero decimal del Label a Binario, mostrandolo en el historial
		/// de la calculadora y en el Label.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ConvertirABinario(object sender, EventArgs e)
		{
			StringBuilder historial = new StringBuilder();
			Operando numero = new Operando();

			double numeroAConvertir;
			string resultado;
			bool flag;
			flag = double.TryParse(this.lblResultado.Text, out numeroAConvertir);

			resultado = numero.DecimalBinario(Math.Abs(numeroAConvertir));
			if (resultado != "Valor Invalido" && !string.IsNullOrEmpty(this.lblResultado.Text) && flag)
			{
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
		/// <summary>
		/// Este evento convertira el numero binario del label en decimal, mostrandolo en el label y en el 
		/// historial de la calculadora.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ConvertirADecimal(object sender, EventArgs e)
		{
			Operando numero = new Operando();
			StringBuilder historial = new StringBuilder();

			string binario = this.lblResultado.Text;
			string resultado;

			resultado = numero.BinarioDecimal(binario);
			if (resultado != "Valor Invalido" && !string.IsNullOrEmpty(binario))
			{

				historial.AppendLine(this.lblResultado.Text + "B" + "= " + resultado + "D");
				this.listBoxHistorial.Items.Add(historial.ToString());
				this.lblResultado.Text = resultado;
			}
			else
			{
				MessageBox.Show(resultado, "Calculadora", MessageBoxButtons.OK);
			}
		}
	}
}
