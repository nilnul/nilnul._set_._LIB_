using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.cobiop_.deltaSect_.rng_.ring
{
	
}

/// this ring cannot replace the normal algebra?
///
///to check whether complement can be derived.
///		for any set <var>a</var>, Omni deleta a = Not(a).
///		
///
///
/// to check for union:
///		(a xor b)  xor (a&b) = a or b
///
/// So this can derive normal algebra for union,intersect and complement
///



///	(note:
///	
///				so algebra is different from funcitonal composition, as in algebra, we have some constants available. in functional compostion, the constants are nullary funcs, and they can appear, or not in the toolset; and its appearance makes difference.
///
/// so we got to be clear that:
///		functional complete
///			vs:
///		algebra complete.
///
/// for algebra complete:
///		1) we can treate a variable as set, member of which is the val assigned at different times, or the expr we extended by applying operations recursively.
///		2) we can bring in enough nodes, each of which corresponds to an op, or a truthTable.
///
///	{}
///	,
///	{0,1}
///	,
///	{0,1,2,3}
/// would generate a ring:
/// {},{0,1}, {2,3}, {0,1,2,3}
///		where {0,1,2,3} means the function would be always true when the input is any member: 0,1,2,3.


/// for x={2,3} corresponds to 00,01,10,11
///		y={1,3} corresponds to 01,11
///
/// and we need omega: {0,1,2,3}
/// now apply operators to generate:
///		omega delta x  = {0,1}      
///		omega delta y = {0,2}
///		intersection, we get {0}
///		, {0} delta {0},  we then get {}
///		, omega delta {0} = {1,2,3}
///		,
///		{2,3} & {1,3} = {3}
///		,
///		{2,3} delta {3} ={2}
///		,
///		{1,2,3} delta {3} = {1,2}
///		,
///		{1,2} delta {2} ={1}
///		,
///		{0} delta {1} ={0,1}
///

/// for x={0,1}, y={0,1}, x* y = { 00,01,10, 11}
///
/// given { 10,11 }, minterms for x =1; and { 01,11}, minterms for y=1, can we get any combination of minterms?
///  let's take Nand operator.
///  {10,01, 00}
///  {01,00,11}
///  {11}
///  ,{10}
///  ,{00,01}
///  ,{11,10}
///  ,{00,10}
///  
/// 


/// for 



/// 
/// 
/// 
/// 
///
/// {}, {0}, {1}, {0,1}
///
/// for projection: {10,11}, {01,11}
/// , can we generate the power set of { 00,01,10, 11}?
///	imaging that xy is the values assigned to the two variable.
///	 by intersection, we get {11}.
///	 by xor we get {10,01}
///	 by intersection, we get {}
///	 by intersect {10,01}, {10,11} we get {10}





///		3) n-projection can be extended to n+1 - projection by complete operations?
///		eg:
///			op(x,x), applied /transformed by different operations, would result to Head truthTable, and Toe truthTable:
///				as projection is incomplete, so this might be false claim.
///	)
/// 
/// 
///

