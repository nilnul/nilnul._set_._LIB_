using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.cobiop_.deltaConcur_
{
	/// <summary>
	///
	/// 
	/// </summary>
	///	to define a Rng. instead, <see cref="deltaSect_"/>
	///
	///
	/// 
	///  {not, xor} is not complete for boolean algebra.
	///  "concur" is "not" "delta"; <see cref="set.op_.binary_.concur_.ByDeltaDual{T}"/>. "not" with "delta" is not complete <see cref="nilnul.bit.op.set_.incomplete_"/>.
	///
	/// check first two of the three conditions for Rng: 
	/// for delta
	///		it has to be abelian group
	///			this implies that it's not empty
	///	for concur
	///		this has to be semigrp
	///			as for the delta, the family is monoid; so the family is not empty.
	///			As for concur, it's semigrp, which is subtype of magma, so it's closed, so omega is inside.
	///			but we cannot gurantee omega is neutral, as when A is not inside omega, A concur Omega is not A.
	/// 
	class RngXpn
	{
	}

}
