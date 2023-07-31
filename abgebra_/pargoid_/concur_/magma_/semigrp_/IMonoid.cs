using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_.concur_.magma_.semigrp_
{
	/// x~x = omega
	/// x~0 = ~x
	/// x~(x|y) = x | !x!y
	/// x~omega=x.
	/// x~!x= phi
	/// 
	/// <summary>
	///	 omega is the neutral element.	
	/// </summary>
	/// <remarks>
	/// eg:
	///		{ 0 }
	///	eg:
	///		{
	///			{a}
	///			,
	///			{a,b}
	///		}
	///	eg:
	///		{
	///			{a}
	///			,
	///			{b}
	///			,
	///			{a,b}
	///			,{} ={a}^{b}
	///		}
	///		
	///	eg:
	///		{
	///			{a,b}
	///			,
	///			{b,c}
	///			,
	///			{a,b,c}
	///			,{b}
	///			,
	///		}
	///		
	///	eg:
	///		{
	///			{a,b}
	///			,
	///			{b,c}
	///			,
	///			{a,b,c,d}
	///			,{b,d}
	///		}
	///			,where we have no kernel.
	///		
	///		
	/// </remarks>
	interface IMonoid
		:
		ISemigroup
		,
		nilnul.set.abgebra_.pargoid_.magma_.semigrp_.monoid_.IGrp	// this is also grp as invers is closed.
		,
		nilnul.set.abgebra_.pargoid_.magma_.semigrp_.monoid_.grp_.IAbelian	// this is also abelian as op is commutative..

	{
	}
}
