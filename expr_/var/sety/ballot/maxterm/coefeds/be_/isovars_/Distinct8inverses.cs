using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefeds.be_.isovars_
{
	public class Distinct8inverses<TEl>
		: maxterm.coefeds.BeI<TEl>
	{


		public bool be(in IEnumerable<Coefed<TEl>> obj)
		{
			return maxterms.be_.isovars_.Distinct<TEl>.Unison.be(
				obj.Select(x=>x.maxterm)
			);
		}

		public bool be(IEnumerable<Coefed<TEl>> obj)
		{
			return be(in obj);
		}
		static public Distinct8inverses<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Distinct8inverses<TEl>>.Unison;
			}
		}

	}
}
