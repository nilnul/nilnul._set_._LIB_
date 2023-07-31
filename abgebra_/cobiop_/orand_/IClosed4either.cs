namespace nilnul.set.abgebra_.cobiop_.orand_
{
	/// <summary>
	/// closed for union; closed for intersect;
	/// </summary>
	/// <remarks>
	/// the closed for union implies: we have the universal set;
	/// the closed for intersection implies: we have the kernel|seed|core|shared set, which is the subset of all sets;
	/// thence:
	///		for union, it's an abelian grp;
	///		for intersect, it's an abelian grp;
	///	so this is in fact a ring; but not yet a domain as we may have only one el;
	/// </remarks>
	public interface IClosed4either
		:IUnionInter,IDwelt
	{ }
}
