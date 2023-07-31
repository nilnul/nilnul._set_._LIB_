using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefeds.be
{
	public class Vow<TEl>
		:
		nilnul.obj.be.Vow_ofIn<
			IEnumerable<
				Coefed<TEl>
			>
		>
		,
		maxterm.coefeds.VowI<TEl>
	{
		public Vow(in BeI_ofIn<IEnumerable<Coefed<TEl>>> val) : base(val)
		{
		}

		public Vow(BeI_ofIn<IEnumerable<Coefed<TEl>>> x) : base(x)
		{
		}
	}
}
