using System;
using System.Collections.Generic;

namespace nilnul.set
{

	/// <summary>
	/// the elEq is not explicit; hence when doing binary operations, the two inputs might be of different elEqs, when we shall throw exception.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///

#if DEBUG

#else

	[Obsolete()]
#endif
	 public interface ExprI<T> :IExpr, nilnul.obj.expr_.typed_.GeneriI<HashSet<T>>{ }




	 interface ExprI :IExpr, nilnul.obj.expr_.typed_.GeneriI<HashSet<object>>{ }





}
