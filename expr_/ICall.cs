namespace nilnul.set.expr_
{
	public interface ICall:
		IExpr
		,obj.expr_.ICall
	{ }

	public interface CallI<T>:
		ICall
		,
		nilnul.set.ExprI<T>
		,
		_call_.OpI
	{ }




}
