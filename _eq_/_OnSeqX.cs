using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using nilnul.obj.seq;

namespace nilnul.set._eq_
{
	static public class _OnSeqX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Eq<T>(
			IEnumerable<T> a, IEnumerable<T> b
			,
			IEqualityComparer<T> comparer
		)
		{

			return a.Except(b, comparer).None() && b.Except(a, comparer).None();
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Eq<T>(
			IEnumerable<T> a, IEnumerable<T> b
		)
		{

			return Eq<T>(a,b,EqualityComparer<T>.Default);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Eq<T,TElEq>(
			IEnumerable<T> a, IEnumerable<T> b
		)
			where TElEq:IEqualityComparer<T>,new()
		{

			return Eq<T>(a, b,
				 nilnul._obj.typ_._UnisonX<TElEq>.Unison
			);
		}
	}
}
