using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.family_
{
	/// <summary>
	/// a subset of powset that is closed under finite union, intersection, and complement.
	/// This is a commutative ring.
	/// It's not domain, as:
	/// 	*) it might contain only the empty set. So it's not integer domain, as integer domain is a nonzero commutative ring.
	///		*) even if it's not singleton. it is still not domain, as two disjoint sets, even nonempty,  intersect into an empty 
	/// </summary>
	/// <remarks>
	/// this is a commutative ring.
	/// </remarks>
	/// ring 2 field.
	///		it's already a ring, but not yet as far as a field.
	///		it can define complement as:
	///			  omega XOR x= not(x)
	///			 complement shall be regarded as the inverse of multi, rather than the negation of plus, as 
	///
	///	    it looks like a field in that:
	///			the plus is abelian group
	///			the multi is semigrp.
	///			
	/// 
	///	ring 2 domain
	///		more than ring, less than domain.
	///		not yet domain
	///	 	
	public interface  IRing
		:nilnul.set.algebra_.cobiop_.deltaSect_.rng_.IRing
	{

	}
}
