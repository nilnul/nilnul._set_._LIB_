using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefed.be_
{
	public class Coef8nonnil<TEl>
		: maxterm.coefed.BeI<TEl>
	{
		public bool be(in Coefed<TEl> obj)
		{
			
			return obj.coef.Any();

		}

		//[MethodImpl()]
		public bool be(Coefed<TEl> obj)
		{
			return be(in obj);
		}


		static public Coef8nonnil<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Coef8nonnil<TEl>>.Unison;
			}
		}

	}
}
