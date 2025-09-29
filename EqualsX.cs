using System;
using System.Collections.Generic;

namespace nilnul.set
{
	[Obsolete(nameof(_eq_._OnSeqX))]
	static public class EqualsX
	{
	




		static public bool Equals<T>(IEnumerable<T> a, IEnumerable<T> b, Func<T, T, bool> equator)
		{

			return new FiniteSet<T>(a, equator).SetEquals(new FiniteSet<T>(b, equator));

		}








	}
}
