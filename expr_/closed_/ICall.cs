using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_
{
	/// <summary>
	/// involving only <see cref="set.IOp{T}"/>. set.Str, etc are not accommodated;
	/// </summary>
	/// <see cref="nilnul.obj.ICall"/>, but here the inputs are expr, not literal value;
	public interface ICall
		:
		IClosed
		,
		INonCommon // it doesnot implement the interface; and its args are not common
	{
	}


}
