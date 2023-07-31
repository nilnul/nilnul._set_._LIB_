namespace nilnul.set.abgebra_.cobiop_.orand_.semi_
{
	/// we require negation, the initial of which, "n", is in "rng"
	/// <summary>
	/// for "union":
	///		it is not only a semigrp, but also an abelian group;
	///		, this requires we have a null element for "union"; the null element might be nonempty, but the kernel of all sets;
	/// </summary>
	/// <remarks>
	/// we doesnot require "intersect" identity, the 1;
	/// eg:
	///		{
	///			{a,b},{a,c},{a}
	///		}
	///		
	///eg:
	///
	///		{
	///			{a}
	///		}
	///		,
	///	eg:
	///		{
	///			{a},{a,b},{a,c},{a,b,c}
	///		}
	///		
	/// </remarks>
	interface IRng :ISemiring
	{
	}


}
