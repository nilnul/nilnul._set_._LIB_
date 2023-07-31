using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.re_.sub_
{
	/// <summary>
	/// If every element in A is in B, and B is not subset of A, we say that A is a properSubSet of B.
	/// x is properSubset of y if x is <see cref="ISubset{TElement}"/> of y , and x is <see cref="IUnEquated"/> to y.
	/// </summary>
	/// alias:
	///		inner
	///			, whileas inside means "in" or on the "side"
	///		internal
	///		
	///		inside, reserved for <see cref="ISubset"/>
	///		within,
	public interface IProperSubset
	{
	}
	

}
