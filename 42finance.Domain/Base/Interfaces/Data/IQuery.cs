using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42finance.Domain.Base.Intefaces.Data
{
	public interface IQuery<T>
	{
		string GetSql();
		object BuildObject();
	}

	public interface IQuery<T, TParameter> : IQuery<T>
	{
		TParameter[] BuildParameterList();
	}
}
