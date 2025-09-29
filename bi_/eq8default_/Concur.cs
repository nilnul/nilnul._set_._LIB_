using nilnul.set_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.eq8default_
{

	public class Concur<TEl,TEq>
		:
		nilnul.obj.Box_ofIn<nilnul.set_.Eq8static<TEl,TEq>>
		,
		nilnul.set.op_.binary_.Eq8defaultI<TEl,TEq>
		,
		nilnul.obj.op_.binary_.ICommutable

		where TEq:IEqualityComparer<TEl>,new()
	{
		public const char Symbol = '~';

		public Concur(in Eq8static<TEl, TEq> val) : base(val)
		{
		}

		public Concur(Eq8static<TEl, TEq> x) : base(x)
		{
		}

		public Eq8static<TEl, TEq> op(Eq8static<TEl, TEq> par, Eq8static<TEl, TEq> par1)
		{
			

			var r = new Eq8static<TEl, TEq>(this.boxed);
			r.SymmetricExceptWith(par);
			r.SymmetricExceptWith(par1);
			return r;

		}




		



	}
}
