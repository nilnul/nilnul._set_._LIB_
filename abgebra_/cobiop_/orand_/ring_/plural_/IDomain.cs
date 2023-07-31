namespace nilnul.set.algebra_.cobiop_.orand_.ring_.plural_
{
	/// <summary>
	/// for nonkernel els:x,y,  we have x intersect y is not kernel.
	/// </summary>
	/// <remarks>
	/// we can intersect all nonkernel els by recursion, and the result would be a noncore;
	/// eg:
	///		{
	///			{a}
	///			,
	///			{a,b}
	///		}
	/// eg:
	///		{
	///			{a}
	///			,
	///			{a,b}
	///			,
	///			{a,b,c}
	///		}
	///	noneg:
	///		{
	///			{a}
	///			,
	///			{a,b}
	///			,
	///			{a,c}
	///			,
	///			{a,b,c}
	///		}, where {a,b} *{a,c} = {a}, which breaks the requirement that noncores intersect to a noncore;
	///		
	/// </remarks>
	interface IDomain : IRing { }
}
