using System.Collections.Generic;

namespace nilnul.set.expr_.var.sety.ballot.minterm.re_
{
	public interface IEquiv

	{ }

	public interface EquivI<TEl>
		:
		ReI<TEl>
		,
		EqI<TEl> /// eg: in <see cref="IEnumerable{T}.Distinct()"/>, we need this;
	{ }
}
