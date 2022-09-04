using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_
{
	

	public interface UnaryI<TEl>
		: nilnul.obj.op_.UnaryI<
			nilnul.obj.SetI2<TEl>
		>
		,
		nilnul.set.IOp<TEl>
	{

	}
}
