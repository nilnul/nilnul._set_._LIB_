namespace nilnul.set.abgebra_.cobiop_.delta9sect_.grp4aug_.monoid4mul_
{
	///
	/// <summary>
	/// as long <see cref="IDelta9sect"/> is closed for any one of the ops, it's a ring;
	/// :
	///		x^x = 0
	///		x^0= 1
	///		x^1 = ~x
	///		so we have no nilard.
	///
	/// 
	///		x &x =x.
	///		x&0=0
	///		x&1=x
	///			
	///
	/// 
	/// </summary>
	/// <remarks>
	///  x^omega= ~x
	/// so this can derive <see cref="abgebra_.triop_.ICommon"/>;
	/// x^y =x&y | !x&!y
	///  so <see cref="triop_.ICommon"/> can derive this.
	///  So the two are equivalent.
	/// </remarks>
	public interface IRing : delta9sect_. semirng_.rng_.IRing{ }
}
