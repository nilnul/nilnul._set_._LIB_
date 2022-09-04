using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.duo_.sameLen
{
	public class ZipSum<T>
	{
		static public T _Eval(
			IEnumerable<T> a,
			IEnumerable<T> b
			,
			nilnul.duo.OpI<T> duoOp
			,
			nilnul.str.AggregateI<T> aggregate	
		) {

			return aggregate.eval(Zip<T>._Eval(a, b, duoOp));

		}

		static public T _Eval(
			IEnumerable<T> a,
			IEnumerable<T> b
			,
			Func<T,T,T> duoOp
			,
			nilnul.str.AggregateI<T> aggregate	
		) {

			return aggregate.eval(Zip<T>._Eval(a, b, duoOp));

		}


	}
}
