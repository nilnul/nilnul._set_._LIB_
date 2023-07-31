using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms.be_.isovars_
{
	public class Distinct<TEl>
		: minterms.BeI<TEl>
	{
		public bool _be_0isovars(in IEnumerable<Minterm<TEl>> obj)
		{
			return obj.Distinct().Count() ==obj.Count();
		}

		public bool be(IEnumerable<Minterm<TEl>> obj)
		{
			return be(in obj);
		}

		public bool be(in IEnumerable<Minterm<TEl>> obj)
		{
			return IsoVars<TEl>.Unison.be(in obj) && _be_0isovars(in obj);
		}

		static public Distinct<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Distinct<TEl>>.Unison;
			}
		}

	}
}
