using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_.delta_.magma_.semigrp_
{
	/// x^omega=~x.
	///
	/// <summary>
	/// x^0=x. so empty set is the identity.
	/// </summary>
	/// <remarks>
	/// is omega inside?
	///	eg:
	///		{
	///			phi,
	///			{a,b}
	///			,{c,d}
	///			,
	///			{a,b,c,d}, which is {a,b}^{c,d}
	///		}, where we have  omega.
	///
	///	eg:
	///		{
	///			phi,
	///			{a,b}
	///			,{b,c}
	///			,
	///			{a,c}, which is {a,b}^{b,c}
	///		}, where we have no omega.
	/// 
	/// </remarks>
	public interface IMonoid:ISemiGroup, _monoid.IDwelt
	{

	}
}
