using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.duo_.sameLen
{
	public class Zip<T>
	{

		static public IEnumerable<T> _Eval(IEnumerable<T> a, IEnumerable<T> b, nilnul.duo.OpI<T> op) {
			return a.Zip(b, op.eval);
		}

		internal static IEnumerable<T> _Eval<T>(IEnumerable<T> a, IEnumerable<T> b, Func<T, T, T> duoOp)
		{
				return a.Zip(b, duoOp);
		}
	}
}
