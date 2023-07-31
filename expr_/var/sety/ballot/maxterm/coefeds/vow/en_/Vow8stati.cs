using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefeds.vow.en_
{
	public class Vow8stati<TEl, TVow>
		: En<TEl>

		where TVow : maxterm.coefeds.VowI<TEl>, new()
	{
		public Vow8stati(in IEnumerable<Coefed<TEl>> val) : base(val,

				 nilnul._obj.typ_._UnisonX<TVow>.Unison

		)
		{
		}

	


		public Vow8stati(IEnumerable<Coefed<TEl>> val) : base(val,

				 nilnul._obj.typ_._UnisonX<TVow>.Unison )
		{
		}
	}
}
