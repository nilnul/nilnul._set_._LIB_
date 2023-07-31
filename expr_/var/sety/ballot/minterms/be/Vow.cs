using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms.be
{
	public class Vow<TEl>
		:
		nilnul.obj.be.Vow_ofIn<
			IEnumerable<
				Minterm<TEl>
			>
		>
		,
		minterms.VowI<TEl>
	{
		public Vow(in BeI_ofIn<IEnumerable<Minterm<TEl>>> val) : base(val)
		{
		}

		public Vow(BeI_ofIn<IEnumerable<Minterm<TEl>>> x) : base(x)
		{
		}
	}
}
