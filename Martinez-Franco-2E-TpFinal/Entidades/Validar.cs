using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
	static public class Validar
	{

		/// <summary>
		/// Valida que la edadMin no sea mayo o igual a la edadMax.
		/// </summary>
		/// <param name="edadMin"></param>
		/// <param name="edadMax"></param>
		/// <returns></returns>
		static public bool Edades(int edadMin, int edadMax) {
			if (edadMin > edadMax || edadMin == edadMax)
			{
				return false;
			}
			else {
				return true;
			}
		}

		/// <summary>
		/// Valida que edad sea mayor de 18 y menor de 100
		/// </summary>
		/// <param name="edad"></param>
		/// <returns></returns>
		static public bool Edades(int edad)
		{
			if (edad <18 || edad>= 100)
			{
				return false;
			}
			else
			{

				return true;
			}
		}

		/// <summary>
		/// Valida que el string sea de solo letras
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		static public bool ValidarCadenaTexto(string str)
		{
			char caracter = ' ';
			for (int i = 0; i < str.Length; i++)
			{
				caracter = str[i];
				if (!char.IsLetter(caracter) && caracter != ' ')
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Valida que el string contenga numeros y letras
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		static public bool ValidarCadenaTextoConNumeros(string str)
		{
			Regex r = new Regex("^[a-zA-Z0-9]+$");

			if (r.IsMatch(str))
			{

				return true;
			}
			return false;
		}

		/// <summary>
		/// Valida que el string solo contenga numeros
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		static public bool ValidarNumero(string str)
		{
			if (str.All(char.IsDigit) && str != string.Empty)
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// Valida que el string sea de len 8 y que sean todos numeros
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public bool ValidarDNI(string dni)
		{

			if (dni != string.Empty && dni.All(char.IsDigit) && dni.Length == 8)
			{
					return true;		
			}
			return false;
		}

		/// <summary>
		/// Valida que el dni ingresado no este repetido.
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public bool ValidateExistingDNI(string dni)
		{
			List<Persona> clientesList = Persona.GetList();
			foreach (Persona item in clientesList)
			{
				if (item.Dni == dni)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Valida las credenciales del admin para poder ingresar al sistema de administradores.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		static public bool ValidateAdmin(string user, string password)
		{
			Admin.VerificarArchivoAdmin();
			List<Admin> adminList = Admin.GetList();
			foreach (Admin item in adminList)
			{
				if (item.User == user && item.Password == password)
				{
					return true;
				}
			}
			return false;
		}

	}
}
