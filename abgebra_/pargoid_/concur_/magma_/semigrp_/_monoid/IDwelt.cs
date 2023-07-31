using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_.concur_.magma_.semigrp_._monoid
{
	///	A ~ phi = ~A
	///	A~ omega =A
	///	A~ superset = A| ~superset = omega - (superset-A) = !(superset - A)
	///	
	/// <summary>
	///  If the family is not empty,
	///		,then we can choose a set A
	///		,A~A is omega,
	///		, so omega is in.
	///		,A~ omega = A
	///		, so omega, the neutral element is in.
	///		
	///		A ~ B -> C
	///			then C ~ A = B
	///			and C ~ B = A
	///	eg:
	///		{omega}
	///			, empty set can be outside.
	///		{
	///			{a,b}
	///			omega
	///		}
	///		
	///		{
	///			{a,b}
	///			,omega ={a,b,c}
	///			,{b,c}
	///			,{b}
	///		}
	///		{
	///			{a,b}
	///			,omega ={a,b,c}
	///			,{b,c}
	///			,{b}
	///			,
	///			{c,a}
	///			,{c}
	///			,{a}
	///		}
	///		
	/// </summary>
	///
	class IDwelt
	{
	}
}
