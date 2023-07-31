using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterms.vow.en_
{
	public class Vow8stati<TEl, TVow>
		: En<TEl>

		where TVow : maxterms.VowI<TEl>, new()
	{
		public Vow8stati(in IEnumerable<Maxterm<TEl>> val) : base(val,

				 nilnul._obj.typ_._UnisonX<TVow>.Unison

		)
		{
		}

	


		public Vow8stati(IEnumerable<Maxterm<TEl>> val) : base(val,

				 nilnul._obj.typ_._UnisonX<TVow>.Unison )
		{
		}
	}
}
