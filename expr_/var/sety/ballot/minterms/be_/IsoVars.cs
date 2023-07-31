using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms.be_
{
	public class IsoVars<TEl>
		: minterms.BeI<TEl>
	{
		public bool be(in IEnumerable<Minterm<TEl>> obj)
		{
			if (obj.Any())
			{
				var f=obj.First();
				return obj.Skip(1).All(s => minterm.re_.IsoVars<TEl>.Unison.re(s, f));
			}
			return true;

		}

		//[MethodImpl()]
		public bool be(IEnumerable<Minterm<TEl>> obj)
		{
			return be(in obj);
		}


		static public IsoVars<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<IsoVars<TEl>>.Unison;
			}
		}

	}
}
