namespace nilnul.set.abgebra_.cobiop_.orand_
{
	/// <summary>
	/// synonym to <see cref="IClosed4either"/>;
	/// no further constraints required, as:
	///		it's required that for add, it's an abelian grp;
	///		hence, we need negations: x + y = core;
	/// </summary>
	/// <remarks>
	/// eg:
	///		{
	///			{a}
	///		}
	///	noneg:	
	///		{
	///			{a}
	///			,
	///			{a,b}
	///		}, where -{a,b} is not defined;
	/// </remarks>
	public interface IRing :IClosed4either { }

	/// can this derive <see cref="nilnul.set.abgebra_.cobiop_.delta9sect_.rng_.IRing"/>?
	/// as we already have and|sect. now we only need to try to derive delta.
	/// x 
}
