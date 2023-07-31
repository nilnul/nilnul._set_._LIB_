using System;

namespace nilnul.set.expr_.var.sety.ballot.minterms.sop
{
	static public class _EqX
	{
		static public bool Eq<T>(
			set.expr_.var.sety.ballot.minterms.Sop<T> x
			,
			set.expr_.var.sety.ballot.minterms.Sop<T> y


		)
		{


			return nilnul.set.expr_.var.sety.ballot.minterms_.canonic.sum.Eq<T>.Unison.Equals(
				x.toCanonic()
				,
				y.toCanonic()
			);


		}
	}


}
