using nilnul.set.expr_.var.sety.ballot.minterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterms.be_.isovars_.distinct.vow
{
	public class En<TEl> :
		maxterms.vow.en_.Vow8stati<
			TEl
			,
			maxterms.be_.isovars_.distinct.Vow<TEl>
		>
		,IMinterms
	{
		public En(in IEnumerable<Maxterm<TEl>> val) : base(val)
		{
		}

		public En(IEnumerable<Maxterm<TEl>> val) : base(val)
		{
		}
	}
}
