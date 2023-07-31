namespace nilnul.set.expr_.closed_
{
	/// <summary>
	/// only using:
	///		complement
	///		union
	///		intersect
	/// </summary>
	public interface ICommon
		:
		IClosed
		,
		closed_.ICall
	{
	}

	public interface CommonI<T>
		:
		ICommon
		,
		expr_.ClosedI<T>
		,
		_common_.ToSopI<T>
		,
		_call_.OpI

	{
	}



}
