using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefed.be
{
	public class Vow<TEl>
		:
		nilnul.obj.be.Vow_ofIn<
			
				Coefed<TEl>
			
		>
		,
		maxterm.coefed.VowI<TEl>
	{
		public Vow(in BeI_ofIn<Coefed<TEl>> val) : base(val)
		{
		}

		public Vow(BeI_ofIn<Coefed<TEl>> x) : base(x)
		{
		}
	}
}
