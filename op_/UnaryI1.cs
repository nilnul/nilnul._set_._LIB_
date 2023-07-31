using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_
{
	

	public interface UnaryI1<TEl>
		:
		nilnul.obj.op_.UnaryI<
			HashSet<TEl>
		>
		,
		nilnul.set.IOp<TEl>
	{

	}


}
