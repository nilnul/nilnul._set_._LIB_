using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterms.be
{
	public class Vow<TEl>
		:
		nilnul.obj.be.Vow_ofIn<
			IEnumerable<
				Maxterm<TEl>
			>
		>
		,
		maxterms.VowI<TEl>
	{
		public Vow(in BeI_ofIn<IEnumerable<Maxterm<TEl>>> val) : base(val)
		{
		}

		public Vow(BeI_ofIn<IEnumerable<Maxterm<TEl>>> x) : base(x)
		{
		}
	}
}
