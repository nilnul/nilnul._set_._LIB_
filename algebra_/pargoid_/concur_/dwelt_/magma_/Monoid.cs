using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.pargoid_.concur_.dwelt_.magma_
{
	/// <summary>
	///		Or can we accept member other than omega, say N,  as the neutral member?
	///				if so, then
	///					N concur Omega =  Omega, as N is neutral
	///						then N must be supset of Omega.
	///					N concur N = N ,as N is neutral.  on the other hand, N concur N = Omega. So N=Omega.
	///		So if there is a neutral, it must be omega.
	///
	///		A concur Omega is A, if A is included within Omega. So A is the inverse of itself.
	///		A concur Omega is A-sected-Omega, if some members of A is outside Omega.
	///			so the result is not A, so Omega is not neutral member as this breaks the requirments of Neutral element.
	///		    for omega to be the neutral member, we need that all members have to be included within omega.
	/// 
	/// </summary>
	///	 empty set can be not a member of the family.
	/// 
	class Monoid:
		nilnul.set.algebra_.pargoid_.magma_.semigrp_.monoid_.IGrp	// this is also grp as invers is closed.
		,
		nilnul.set.algebra_.pargoid_.magma_.semigrp_.monoid_.grp_.IAbelian	// this is also abelian as op is commutative..

	{
	}
}
