using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.valve.phrase_
{
	static public class _AsNop0complementX
	{
		static public string Phrase<TEl>(
			KeyValuePair<Var<TEl>, bool> x
		)
		{
			return x.Value?$"{x.Key}":$"!{x.Key}";
		}



	}
}
