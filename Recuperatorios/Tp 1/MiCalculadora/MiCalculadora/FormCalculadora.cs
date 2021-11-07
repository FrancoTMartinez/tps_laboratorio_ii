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
		/// Cuando se realiza el click en dicho boton, llama al metodo estatico correspondiente para realizar la operacion para
		/// luego escribir los resultados en el label y en el listbox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OperarNumeros(object sender, EventArgs e)
		{
			char.TryParse(this.cmbBoxOperando.Text, out char operador);
			double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, operador);

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
		/// Metodo que realiza las operaciones con los datos ingresados
		/// </summary>
		/// <param name="numero1"> numero ingresado en el boton 1</param>
		/// <param name="numero2">numero ingresado en el boton 2</param>
		/// <param name="operador"> operador </param>
		/// <returns></returns>
		private static double Operar(string numero1, string numero2, char operador)
		{
			Operando num1 = new Operando(numero1);
			Operando num2 = new Operando(numero2);
			

			for (int i = 0; i < numero1.Length; i++)
			{
				if (numero1[i] >= 'a' || numero1[i] >= 'A')
				{
					MessageBox.Show("No es posible realizar operacion con letras");
					break;
				}
			}
			for (int j = 0; j < numero2.Length; j++)
			{
				if (numero2[j] >= 'a' || numero2[j] >= 'A')
				{
					MessageBox.Show("No es posible realizar operacion con letras");
					break;
				}
			}

			double resultado = Calculadora.Operar(num1, num2, operador);
			return resultado;
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
