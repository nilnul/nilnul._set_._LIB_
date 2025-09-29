using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.concur
{
	public class Cumulator<TEl> : nilnul.obj.op_.binary.Cumulator<
		nilnul.obj.SetI2<TEl>
		,
		Concur<TEl>

	>
	{
		public Cumulator( Concur<TEl> binder) : base(binder.omegaAsSet, binder)
		{
		}

	}
}
