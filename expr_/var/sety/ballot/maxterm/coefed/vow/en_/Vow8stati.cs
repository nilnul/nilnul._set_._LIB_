using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefed.vow.en_
{
	public class Vow8stati<TEl, TVow>
		: En<TEl>

		where TVow : maxterm.coefed.VowI<TEl>, new()
	{
		public Vow8stati(in Coefed<TEl> val) : base(val,

				 nilnul._obj.typ_._UnisonX<TVow>.Unison

		)
		{
		}

	


		public Vow8stati(Coefed<TEl> val) : base(val,

				 nilnul._obj.typ_._UnisonX<TVow>.Unison )
		{
		}
	}
}
