using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.set;
using nilnul.collection.set.op.expr;

namespace nilnul.set.re_
{
	static public class _JointX
	{
		static public bool Re<T>(HashSet<T> a, HashSet<T> b)
		{
			return a.Intersect(b, a.Comparer).Any();

		}


		static public bool Re<T>(IEnumerable<T> a, IEnumerable<T> b, IEqualityComparer<T> elEq)
		{
			return a.Intersect(b, elEq).Any();

		}




		static public bool Re<T, Eq>(nilnul.obj.Set<T, Eq> a, nilnul.obj.Set<T, Eq> b)
			where Eq : IEqualityComparer<T>, new()
		{
			return a.Intersect(b, a.Comparer).Any();
		}

		static public bool Re<T, Eq>(IEnumerable<T> a, IEnumerable<T> b)
			where Eq : IEqualityComparer<T>, new()
		{
			return Re<T>(a,b,nilnul.obj_.Singleton<Eq>.Instance);
		}



	}
}
