namespace nilnul.set.algebra_.cobiop_.orand_.ring_.plural_.domain_.field_.xpn_
{
	/// <summary>
	/// if we have no less than 3 els, then it cannot be a field;
	/// </summary>
	/// <remarks>
	///	eg:
	///		{
	///			{a}
	///			,
	///			{a,b}
	///			,
	///			{a,b,c}
	///		}, where if we define 1/{a,b} = {a,b,c}, then by multiplying either side with {a,b}, we get {a,b,c} =  {a,b}, a contradiction.
	///		
	/// </remarks>
	interface IPoliad : IXpn { }
}
