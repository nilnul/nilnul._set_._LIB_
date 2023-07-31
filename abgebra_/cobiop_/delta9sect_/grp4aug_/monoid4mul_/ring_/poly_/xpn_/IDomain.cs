using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_.delta9sect_.ring_.poly_.xpn_
{
	/// <summary>
	/// the nonempty sets intersected to nonempty, which is disjoint from the input nonempty; and if we intersect again, we would get an empty set; but domain requires nonempty set multiplies to nonempty;
	/// </summary>
	/// eg:
	///		
	///		{
	///			0
	///			,
	///			{a}
	///			,
	///			{a,b}
	///			,
	///			{b}  //by delta
	///				// then {a} & {b} = empty, breaks the requirement that nonnils form a commutative monoid for mul.
	///		}

	internal class IDomain
	{
	}
}
