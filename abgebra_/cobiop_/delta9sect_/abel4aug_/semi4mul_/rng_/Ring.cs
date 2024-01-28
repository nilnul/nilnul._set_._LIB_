using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_.delta9sect_.abel4aug_.semi4mul_.rng_
{
	///	for intersect
	///		we need it's not only a semigrp, but also a monoid;
	///		,this requires we have a universal set. And we have achieved this;
	/// the neutral for multi  intersects with any set is the set. So the neutral must be the superset of every set.
	///
	/// 
	/// <summary>
	/// if it is Rng, and
	///		if there is identity for the sect op
	///			the neutral shall be the universal, or the union of all.
	///	Note:
	///		sect inverse is not required. it's the field that requires multi inverse 
	///		
	///		This is not integer domain, as domain requirs that  two nonnil sets multi into nonnil, but if the two sets are disjoint, this is not achieveable.
	/// </summary>
	/// <remarks>
	/// <see cref="delta9sect_.IRing"/>
	/// this is a boolean|powset ring. boolean ring  and boolean algebra are equiv.
	/// any finite Boolean ring has as cardinality a power of two.
	/// this is a subalgebra of powerset of X;
	/// </remarks>
	/// 
	public interface  IRing
	{
	}
}

/// this ring cannot replace the common algebra| <see cref="nilnul.set.abgebra_.common_.IClosed"/>?
///
///to check whether complement can be derived.
///		for any set <var>a</var>, Omni deleta a = Not(a).
///		
///
///
/// to check for union:
///		(a xor b)  xor (a&b) = a or b
///
/// So this can derive common algebra for union,intersect and complement
///


