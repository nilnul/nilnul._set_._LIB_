using System;

namespace nilnul.set.expr_.closed_.call
{
	static public class _EqX
	{
		static public bool _Eq_byNonref<T>(
			set.expr_.closed_.CallI<T> x
			,
			set.expr_.closed_.CallI<T> y


		)
		{
	
			return nilnul.set.expr_.var.sety.ballot.minterms_.canonic.sum.Eq<T>.Unison.Equals(
				x.toCommon().toSop().toCanonic()
				,
				y.toCommon().toSop().toCanonic()
			);

		}
		static public bool Eq<T>(
			set.expr_.closed_.CallI<T> x
			,
			set.expr_.closed_.CallI<T> y


		)
		{
			if (object.ReferenceEquals(x,y) )
			{
				return true;
			}

			return _Eq_byNonref(x,y);

		}


	}


}
