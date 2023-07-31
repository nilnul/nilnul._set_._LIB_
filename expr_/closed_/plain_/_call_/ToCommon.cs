using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.plain_._call_
{
	/// <summary>
	/// for var, make it:
	///		identity(var)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ToCommonI<T>
	{
		closed_.CommonI<T> toCommon();
	}
}
