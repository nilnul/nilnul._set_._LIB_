using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_._closed_
{
	/// <summary>
	/// only some 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	/// dont's do this on closed, as common is a subtype of <see cref="IClosed"/>, and it doesnot need to implement this.
	public interface ToCommonI<T>
	{
		closed_.CommonI<T> toCommon();
	}
}
