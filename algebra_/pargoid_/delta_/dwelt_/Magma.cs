using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.pargoid_.delta_.dwelt_
{
	/// <summary>
	/// it's dwelt, so there must be one element. For this element, it deltas itself and there would be empty element.
	///	
	/// it's magma, so the operation is closed.
	///
	/// As the albebra is closed, then the empty element is inside.
	///
	/// now that it's a monoid, every element has itself as the inverse, so it's group.
	/// 
	/// </summary>
	/// it's derived that is also
	///		monoid
	///			emtpySet is the neutral
	///		 group
	///			the inverse of each member is itself
	///		 abelian
	///			the op is commutative.
	/// 
	class Magma
		:
		nilnul.set.algebra_.pargoid_.magma_.semigrp_.monoid_.grp_.IAbelian
	{

	}
}
