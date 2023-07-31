using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_
{

	[Obsolete(nameof(BinaryI1<TEl>))]
	public interface BinaryI<TEl>
		: nilnul.obj.op_.BinaryI<
			nilnul.obj.SetI2<TEl>
		>
		,
		nilnul.set.IOp<TEl>
	{

	}

}
