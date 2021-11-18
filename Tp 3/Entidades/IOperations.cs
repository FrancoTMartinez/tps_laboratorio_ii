using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	interface IOperations<T> where T : class
	{
		bool AddToList(T obj);
		bool DeleteFromList(int id);
		bool UpdateFromList(T obj);
		

	}
}
