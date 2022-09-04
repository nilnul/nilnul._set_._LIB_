using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be
{
	public class Vow<TEl>
		:
		nilnul.obj.be.Vow4<
			nilnul.set.Family<TEl>
			>
		,
		nilnul.set.family.VowI<TEl>
	{
		public Vow(BeI1<Family<TEl>> be) : base(be)
		{
		}

	}
}
