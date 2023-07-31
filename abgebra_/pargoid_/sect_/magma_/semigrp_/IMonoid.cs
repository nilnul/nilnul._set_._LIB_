using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_.sect_.magma_.semigrp_
{

	/// <summary>
	/// eg:
	///		{{a}}
	///		,
	///		{{a,b},{a}}
	///		,
	///		{{a,b},{a},{b}, {phi} }
	///		,
	///		{{a,b,c}, {a},{a,b} }
	///		,
	///		{{a,b,c}, {a},{a,b},{a,c} }
	///		
	/// </summary>
	/// <remarks>
	///derived that: one set is the subset of all.
	/// </remarks>
	public interface IMonoid:ISemigrp,_monoid.has_.IOmega
	{
	}
}
