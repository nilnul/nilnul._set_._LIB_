using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.unary_
{
	

	public interface EqDefaultI<TEl,TEq>
		:
		nilnul.obj.op_.UnaryI<
			nilnul.set_.Eq8static<TEl,TEq>
		>
		,
		nilnul.set.IOp<TEl,TEq>

		where TEq:IEqualityComparer<TEl>,new()
	{

	}
}
