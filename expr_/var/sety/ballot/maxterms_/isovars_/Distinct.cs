using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterms_.isovars_
{
	public class Distinct<TEl> :
		maxterms.vow.en_.Vow8stati<
			TEl
			,
			maxterms.be_.isovars_.distinct.Vow<TEl>
		>
		,IMaxterms
	{
		public Distinct(in IEnumerable<Maxterm<TEl>> val) : base(val)
		{
		}

		public Distinct(IEnumerable<Maxterm<TEl>> val) : base(val)
		{
		}
	}
}
