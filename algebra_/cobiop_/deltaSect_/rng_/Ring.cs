using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.cobiop_.deltaSect_.rng_
{
	/// the neutral for multi  intersects with any set is the set. So the neutral must be the superset of every set.
	/// 
	/// <summary>
	/// if it is Rng, and
	///		if there is identity for the sect op
	///			the neutral shall be the universal, or the union of all.
	///	Note:
	///		sect inverse is not required. it's field that requires multi inverse 
	///		
	///		This is not integer domain, as domain requirs that  two nonnil sets multi into nonnil, but if the two sets are disjoint, this is not achieveable.
	/// </summary>
	/// this is a boolean ring. boolean ring  and boolean algebra are equiv.
	public interface  IRing
	{
	}
}

/// this ring cannot replace the normal algebra?
///
///to check whether complement can be derived.
///		for any set <var>a</var>, Omni deleta a = Not(a).
///		
///
///
/// to check for union:
///		(a xor b)  xor (a&b) = a or b
///
/// So this can derive normal algebra for union,intersect and complement
///


