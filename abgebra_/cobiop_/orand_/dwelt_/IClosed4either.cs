namespace nilnul.set.abgebra_.cobiop_.orand_.dwelt_
{
	/// <summary>
	/// closed for union; closed for intersect;
	/// </summary>
	/// <remarks>
	/// the closed for union implies: we have the universal set;
	/// the closed for intersection implies: we have the kernel|seed|core|shared set, which is the subset of all sets;
	/// thence:
	///		for union, it's a commutive monoid;
	///		for intersect, it's a commutive monoid;
	///	so this is in fact a rig; but not yet a ring as we don't have negation for "or";
	/// </remarks>
	public interface IClosed4either
		:IDwelt
	{ }
}
