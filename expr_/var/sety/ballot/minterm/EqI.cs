using System.Collections.Generic;

namespace nilnul.set.expr_.var.sety.ballot.minterm
{
	public interface IEq

	{ }

	public interface EqI<TEl>
		:
		IEqualityComparer<Minterm<TEl>> /// eg: in <see cref="IEnumerable{T}.Distinct()"/>, we need this;
		,
		IEq
	{ }
}
