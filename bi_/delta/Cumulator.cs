using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.delta
{
	public class Cumulator<TEl> : nilnul.obj.op_.binary.cumulator_.OpDefault<
		nilnul.obj.SetI2<TEl>
		,
		binary_.Delta<TEl>
	>
	{
		public Cumulator() : base(new nilnul.obj.Set2<TEl>())
		{
		}
	}
}
