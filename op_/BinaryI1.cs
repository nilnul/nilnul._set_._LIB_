using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_
{

	//[Obsolete(nameof(of_.IBinary))]
	public interface BinaryI1<TEl>
		: nilnul.obj.op_.BinaryI<
			HashSet<TEl>
		>
		,
		nilnul.set.op_.IBinary
		,
		nilnul.set.IOp<TEl>
	{

	}



}
