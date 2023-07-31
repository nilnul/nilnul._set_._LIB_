using nilnul.obj.seq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety
{
	static public class _EqX
		
	{
		static public bool Eq<TEl>(
			IEnumerable<Var<TEl>> a, IEnumerable<Var<TEl>> b
		)
		{
			return nilnul.set._eq_._OnSeqX.Eq(a, b);

		}
		//static public bool _Re_01sets<T>(
		//	IEnumerable<Var<T>> a, IEnumerable<Var<T>> b
		//)
		//{

		//	return a.Except(b).None() && b.Except(a).None();
		//}

	}
}
