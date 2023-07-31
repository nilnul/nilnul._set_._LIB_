using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_._closed_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// <see cref="expr_.Closed{T}"/> is hard to implement this;
	/// </remarks>
	public interface ToCanonicI<T>
	{
		//closed_.CanonicI<T> toCanonic();
		set.expr_.var.sety.ballot.minterms_.canonic.Sum<T> toCanonic();

	}
}
