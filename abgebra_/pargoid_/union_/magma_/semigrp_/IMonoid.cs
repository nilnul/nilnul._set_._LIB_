using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_.union_.magma_.semigrp_
{

	/// <summary>
	/// eg:
	///		{phi}
	///		,
	///		{phi,{a}}
	///		,
	///		{phi,{a},{b}, {a,b} }
	///		,
	///		{phi, {a},{a,b} }
	///		,
	///		{phi, {a},{a,b},{a,c} ,{a,b,c} }
	///		
	///		{ {a},{a,b},{a,c}, {a,b,c} }
	///		
	///		{ {a},{a,b,c},{a,c,d}, {a,b,c,d} }
	///		
	/// </summary>
	/// <remarks>
	/// derived that one set is the superset of all.
	/// </remarks>
	public interface IMonoid:ISemigrp,_monoid.IDwelt
	{
	}
}
