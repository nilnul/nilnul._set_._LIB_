using System.Collections.Generic;

namespace nilnul.set.expr_
{
	public interface Eq8static<T,TEq>
		:
		nilnul.obj.expr_.typed_.GeneriI<nilnul.set_.Eq8static<T,TEq>>
		,
		nilnul.set.IExpr<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

	}






}
