using System.Collections.Generic;

namespace nilnul.set.op_
{
	public interface TernaryI<TEl>
		: nilnul.obj.op_.TernaryI<
			HashSet<TEl>
		>
		,
		nilnul.set.IOp<TEl>
		,
		ITernary<TEl>
	{

	}



}
