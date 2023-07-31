namespace nilnul.set.algebra_.cobiop_.orand_.ring_.plural_.domain_
{
	/// <summary>
	/// noncore els form an abelian grp over intersect;
	/// </summary>
	/// <remarks>
	/// as grp reqires, we need inversing:<see cref="orand.el.re_.IInverse"/> for every noncore element:<see cref="orand.el_.INonCore"/>. but per <see cref="orand.el.re_.IInverse"/>, every noncore has to be universal.
	/// So,
	/// eg:
	///		{
	///			{a}
	///			,
	///			{a,b}
	///		}
	///		is a field, as we can define 1/{a,b}={a,b}
	///	noneg:
	///		{
	///			{a}
	///			,
	///			{a,b}
	///			,
	///			{a,b,c}
	///		}, where if we define 1/{a,b} = {a,b,c}, then by multiplying either side with {a,b}, we get {a,b,c} =  {a,b}, a contradiction.
	///		
	/// </remarks>
	interface IField : IDomain { }
}
