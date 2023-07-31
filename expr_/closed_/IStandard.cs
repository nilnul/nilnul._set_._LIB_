namespace nilnul.set.expr_.closed_
{
	/// <summary>
	/// </summary>
	/// alias:
	///		std
	///			, "s"um of product
	///		normal
	///		normal form
	///			,<see cref="ICanonic"/>
	public interface IStandard
		:
		ICommon
	{
	}

	public interface StandardI<T>
		:
		IStandard
		,
		expr_.ClosedI<T>
	{
	}



}
