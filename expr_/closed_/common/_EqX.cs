using System;

namespace nilnul.set.expr_.closed_.common
{
	static public class _EqX
	{
		static public bool Eq<T>(
			set.expr_.closed_.CommonI<T> x
			,
			set.expr_.closed_.CommonI<T> y


		)
		{


			return nilnul.set.expr_.var.sety.ballot.minterms_.canonic.sum.Eq<T>.Unison.Equals(
				x.toSop().toCanonic()
				,
				y.toSop().toCanonic()
			);


		}
	}


}
