namespace Entidades
{
	static public class Calculadora
	{
		/// <summary>
		/// Recbie por parametro dos objetos del tipo Operando y uno del tipo char.
		///	En base al operador del tipo char se realizara la operacion correspondiente
		/// </summary>
		/// <param name="num1"></param>
		/// <param name="num2"></param>
		/// <param name="operador"></param>
		/// <returns></returns>
		public static double Operar(Operando num1, Operando num2, char operador)
		{

			double resultado=0;
			operador = Calculadora.ValidarOperador(operador);
			switch (operador)
			{
				case '+':
					resultado= num1 + num2;
					break;
				case '-':
					resultado = num1 - num2;
					break;
				case '/':
					resultado = num1 / num2;
					break;
				case '*':
					resultado = num1 * num2;
					break;
			}
			return resultado;
		}

		/// <summary>
		/// Recibe un char operador el cual representa el tipo de operacion a realizar. 
		/// En caso de que sea valido retornara el operador, caso contrario retornara el operador de suma
		/// </summary>
		/// <param name="operador"></param>
		/// <returns></returns>
		static private char ValidarOperador(char operador)
		{

			switch (operador)
			{
				case '+': break;
				case '-': break;
				case '/': break;
				case '*': break;
				default:
					operador = '+';
					break;
			}
			return operador;
		}

	}
}
