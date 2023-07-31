using System.Collections.Generic;

namespace nilnul.set.expr_.eq8static_
{
	public interface Omega8staticI<T,TEq,TOmega>
		:
		nilnul.obj.expr_.typed_.GeneriI<nilnul.set_.Eq8static<T,TEq>>
		,
		nilnul.set.IExpr<T,TEq,TOmega>
		where TEq:IEqualityComparer<T>,new()
		where TOmega:nilnul.set_.Eq8static<T,TEq>,new()
	{

	}

}
