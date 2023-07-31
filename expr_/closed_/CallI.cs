namespace nilnul.set.expr_.closed_
{


	/// <summary>
	/// it's a call, and much more predictable so that we can be assured that the <see cref="_call_.ToCommonI{T}"/> will work;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface CallI<T>
		:
		expr_.ClosedI<T>,ICall
		,
		_call_.ToCommonI<T>
		,
		_call_.OpI

	{
	}


}
