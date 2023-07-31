namespace nilnul.set.expr_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// vs:
	///		<see cref="set.ExprI"/> which is intended as dynamic typed expr. per nilnul dev, generic shall be prior to nongeneric for membered interface, so <see cref="set.ExprI{T}"/> would be prior to <see cref="set.ExprI"/>. this shall inherit <see cref="set.ExprI"/> and has to be put under <see cref="set.expr_"/>
	public interface GeneriI<T>
		:
		nilnul.obj.expr_.typed_.GeneriI<nilnul.ISet<T>>
	{
	}

}
