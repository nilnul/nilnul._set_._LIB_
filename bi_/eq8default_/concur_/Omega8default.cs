using nilnul.set_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.eq8default_.concur_
{

	public class Omega8default<TEl,TEq,TOmega>
		:
		Concur<TEl,TEq>
		,
		nilnul.set.op_.binary_.Eq8defaultI<TEl,TEq>
		,
		nilnul.obj.op_.binary_.ICommutable

		where TEq:IEqualityComparer<TEl>,new()
		where TOmega: nilnul.set_.Eq8static<TEl,TEq>,new()
	{


		public Omega8default(Eq8static<TEl, TEq> x) : base(
				 nilnul._obj.typ_._UnisonX<TOmega>.Unison
				)
		{
		}



	}
}
