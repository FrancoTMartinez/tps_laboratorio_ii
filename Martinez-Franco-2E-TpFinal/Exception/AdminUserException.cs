using System;

namespace Excepciones
{
	public class AdminUserException : Exception
	{
		public AdminUserException(string exception) :base(exception)
		{

		}
	}
}
