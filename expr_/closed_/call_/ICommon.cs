namespace nilnul.set.expr_.closed_.call_
{
	/// <summary>
	/// only using:
	///		complement
	///		union
	///		intersect
	/// </summary>
	public interface ICommon
		:
		ICall
	{
	}

	public interface CommonI<T>
		:
		ICommon
		,
		expr_.closed_.CallI<T>
		
	{
	}



}
