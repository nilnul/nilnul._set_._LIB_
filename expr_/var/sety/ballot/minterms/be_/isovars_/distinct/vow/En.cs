using nilnul.set.expr_.var.sety.ballot.minterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms.be_.isovars_.distinct.vow
{
	public class En<TEl> :
		minterms.vow.en_.Vow8stati<
			TEl
			,
			minterms.be_.isovars_.distinct.Vow<TEl>
		>
		,IMinterms
	{
		public En(in IEnumerable<Minterm<TEl>> val) : base(val)
		{
		}

		public En(IEnumerable<Minterm<TEl>> val) : base(val)
		{
		}
	}
}
