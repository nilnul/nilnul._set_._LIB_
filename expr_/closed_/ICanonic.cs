namespace nilnul.set.expr_.closed_
{
	/// <summary>
	/// <see cref="nilnul.set.expr_.var.sety.ballot.minterms_.canonic.Sum{T}" />
	/// </summary>
	/// <remarks>
	/// note: this is not <see cref="ICommon"/> as the product or sum is not common operators;
	/// </remarks>
	/// alias:
	///		main normal form
	///			
	public interface ICanonic
		:
		IClosed
		,
		IStandard

	{
	}

	public interface CanonicI<T>
		:
		ICanonic
		,
		expr_.ClosedI<T>
	{
	}



}
