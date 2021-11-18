using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
	public class AdminPasswordExceptioncs : Exception
	{
		public AdminPasswordExceptioncs(string message): base(message)
		{

		}
	}
}
