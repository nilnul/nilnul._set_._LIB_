using nilnul.set.abgebra_.cobiop_.delta9sect_;

namespace nilnul.set.abgebra_.cobiop_.delta9sect_
{
	/// <summary>
	/// closed for delta; closed for intersect;
	/// </summary>
	/// <remarks>
	/// the closed for intersection implies: we have the kernel|seed|core|shared set, which is the subset of all sets;
	/// the closed for delta implies: (x delta y) delta (x&y) = x |y.  we have the universal set;
	///		also x^x = empty. so empty is the core
	///
	/// sect is ditributive over delta;
	/// 
	/// thence:
	///		for intersect, it's an abelian grp;
	///		for delta, it's an abelian grp;
	///	so this is in fact a ring; but not yet a domain as we may have only one el;
	/// </remarks>
	/// If the universal set is forbidden, set operators are restricted to being falsity- (Ø) preserving, and cannot be equivalent to functionally complete Boolean algebra.
	/// So this is equivalent to <see cref="triop_.common_.IClosed"/>, but for bit, common abgebra with delta9sect being closed doesnot mean completeness, as 1 cannot be achieved.
	public interface IClosed4either
		:
		//cobiop_.IDeltaInter,
		IDwelt
	{ }
}
