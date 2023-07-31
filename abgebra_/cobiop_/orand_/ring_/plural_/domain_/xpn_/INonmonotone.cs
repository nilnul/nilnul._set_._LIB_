namespace nilnul.set.algebra_.cobiop_.orand_.ring_.plural_.domain_.xpn_
{
	/// <summary>
	/// the els have to be monotone, like Russian nesting dolls;
	/// </summary>
	/// <remarks>
	///	neg:
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
	interface INonmonotone : IXpn { }
}
