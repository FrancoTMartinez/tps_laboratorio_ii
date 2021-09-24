using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Operando
	{
		private double numero;

		public Operando() :this(0) {

		}

		public Operando(double numero){
			this.numero = numero;
		}
		public Operando(string strNumero) {
			this.Numero = strNumero;
		}


		private string Numero {
			set {
				numero = ValidarOperando(value);
			}
		}

		/// <summary>
		/// Obtiene por parametro un string de 0s y 1s, y retorna ese numero bianrio en decimal, en caso
		/// de no poder convertirlo retorna "valor invalido"
		/// </summary>
		/// <param name="binario"></param>
		/// <returns></returns>
		public string BinarioDecimal(string binario)
		{
			if (EsBinario(binario))
			{
				int numeroBinario;
				int aux;
				int valorDecimal=0;
				int baseVal = 1;
				string resultado;

				if (int.TryParse(binario, out numeroBinario)) {
					while (numeroBinario>0) {
						aux = numeroBinario % 10;
						valorDecimal = valorDecimal + aux * baseVal;
						numeroBinario = numeroBinario / 10;
						baseVal = baseVal * 2;
					}
					return resultado = valorDecimal.ToString();
				}
			}
			else {
				return "Valor Invalido";
			}
			return "Valor Invalido";
		}

		/// <summary>
		/// Recibe un numero decimal y retorna un string de 0s y 1s haciendo asi el pasaje a binario.
		/// </summary>
		/// <param name="numero"></param>
		/// <returns></returns>
		public string DecimalBinario(double numero)
		{
			string result=null;
			for (int i=0;numero>0;i++) {
				result= numero % 2 + result;
				numero = (int)numero / 2;
			}
			
			return result;
		}

		/// <summary>
		/// Recibe un string que contiene numeros, se valida que sea solo numeros y se asigna su valor en una variable
		/// del tipo double para despues pasarlo a binario y retornar su valor binario en string.
		/// </summary>
		/// <param name="numero"></param>
		/// <returns></returns>
		public string DecimalBinario(string numero)
		{
			double decimalValor;
			string resultado;

			if (double.TryParse(numero, out decimalValor))
			{
				resultado= DecimalBinario(Math.Abs(decimalValor));

				return resultado;
			}
			else {
				return "Valor Invalido";
			}

		}

		/// <summary>
		/// Valida que el string solo contenga 0s y 1s, caso contrario retorna false.
		/// </summary>
		/// <param name="binario"></param>
		/// <returns></returns>
		private bool EsBinario(string binario)
		{
			char valorPosicion;
			for (int i = 0; i < binario.Length; i++)
			{
				valorPosicion = binario.ElementAt(i);
				if (valorPosicion != '1' && valorPosicion != '0') {
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Recibo por parametro un string que contiene numeros, valido que solo contenga numeros y lo retorno en una
		/// variable del tipo double
		/// </summary>
		/// <param name="strNumero"></param>
		/// <returns></returns>
		private double ValidarOperando(string strNumero) {
			double resultado;

			double.TryParse(strNumero, out resultado);

			return resultado;
		}

		
		/// <summary>
		/// Las sobrecargas de operador son utlizadas para realizar dichas operaciones de la calculadora de manera
		/// mas optima.
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <returns></returns>
		public static double operator -(Operando n1, Operando n2) 
		{
			return n1.numero - n2.numero;
		}
		public static double operator *(Operando n1, Operando n2)
		{
			return n1.numero * n2.numero;
		}

		/// <summary>
		/// En este caso si el segundo numero es un cero retornara el double.MinValue.
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <returns></returns>
		public static double operator /(Operando n1, Operando n2)
		{
			if (n2.numero==0) {
				return double.MinValue;
			}
			return n1.numero / n2.numero;
		}
		public static double operator +(Operando n1, Operando n2)
		{
			
			return  n1.numero + n2.numero;
		}



	}
}
