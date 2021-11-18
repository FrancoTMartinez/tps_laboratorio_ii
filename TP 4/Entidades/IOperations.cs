using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	interface IOperations<T> where T : class
	{
		bool AddToDB(T obj);
		bool DeleteFromDB(int id);
		bool UpdateFromDB(T obj);
	}
}
