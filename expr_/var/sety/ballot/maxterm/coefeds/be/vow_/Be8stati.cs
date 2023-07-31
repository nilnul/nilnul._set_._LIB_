using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefeds.be.vow_
{
	public class Be8stati<TEl, TBe>
		:
		Vow<TEl>
		where TBe : nilnul.obj.BeI_ofIn<IEnumerable<Coefed<TEl>>>, new()
	{
	

		public Be8stati() : base(
				 nilnul._obj.typ_._UnisonX<TBe>.Unison
				)
		{
		}


		static public Be8stati<TEl, TBe> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Be8stati<TEl, TBe>>.Unison;
			}
		}

	}
}
