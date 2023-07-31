using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_.delta9concur_
{
	/// <summary>
	/// family is empty,
	///		or {phi}
	/// 
	/// </summary>
	///	to define a Rng. instead, <see cref="delta9sect_"/>
	///
	///
	/// 
	///  {not, delta} is not complete for boolean algebra.
	///  "concur" is "not" "delta"; <see cref="set.op_.binary_.concur_.ByDeltaDual{T}"/>. "not" with "delta" is not complete <see cref="nilnul.bit.op.set_.incomplete_"/>.
	///
	/// check first two of the three conditions for Rng: 
	/// for delta
	///		<see cref="abgebra_.pargoid_.delta_.magma_.semigrp_.monoid_.grp_.IAbelian"/>
	///		it has to be abelian group
	///			this implies that the family is not emptyFamily
	///		note x^x = emptySet, not emptyFamily;
	///		emtpySet is the nilard element;
	///		
	///	for concur
	///		this has to be semigrp
	///			as for the delta, the family is monoid; so the family is not empty.
	///			As for concur, it's semigrp, which is subtype of magma, so it's closed; x ~x =omega, so omega is inside.
	///			omega is neutral for concur; so omega is the oneous; when A is inside omega, A concur Omega is A.
	///
	/// note as x~x needs omega being defined, here we need the omega nary operator to be explicitly defined. We cannot have the omega by union all, as we canot get the union operator.
	/// 
	class Rng
	{
	}

}
