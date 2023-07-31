using System.Collections.Generic;

namespace nilnul.set.expr_.eq8implic_
{
	/// <summary>
	/// all instances are taken as the omega set. we assume the omega set is finite. if it's infinte, that doesnot affect the correctness of the result in most cases, and we would not use the result if the omega set is infinite;
	/// </summary>
	/// <remarks>
	/// for infinite one, <see cref="nilnul.collection"/>
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	public interface Omega8implicI<T>
		:
		nilnul.set.expr_.Eq8implicitI<T>
	{

	}

}
