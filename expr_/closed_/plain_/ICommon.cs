namespace nilnul.set.expr_.closed_.plain_
{
	/// <summary>
	/// only using:
	///		complement
	///		union
	///		intersect
	/// </summary>
	public interface ICommon
		:
		IPlain
	{
	}

	public interface CommonI<T>
		:
		ICommon
		,
		expr_.closed_.PlainI<T>
		
	{
	}



}
