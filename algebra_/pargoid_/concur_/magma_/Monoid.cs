using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.pargoid_.concur_.magma_
{
	/// <summary>
	///  the family can be not empty.
	///	we need to ensure the operation is closed (not overflown).
	///		A concur A is Omega. So omega has to be in.
	///		A concur Omega is A. So A is the inverse of itself.
	///		A concur Omega is A-sected-Omega, if some members of A is outside Omega.
	///			so the result is not A, this breaks the requirments of Neutral element.
	///		    so all members have to be inside omega.
	///		A concur B -> c
	///			then C concur A = B
	///			
	///	 empty set can be outside.
	///		
	/// </summary>
	class Monoid:
		nilnul.set.algebra_.pargoid_.magma_.semigrp_.monoid_.IGrp	// this is also grp as invers is closed.
		,
		nilnul.set.algebra_.pargoid_.magma_.semigrp_.monoid_.grp_.IAbelian	// this is also abelian as op is commutative..

	{
	}
}
