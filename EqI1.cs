using System.Collections.Generic;

namespace nilnul.set
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		eq, which is occupied in _nilnul_
	public interface EqI1<T>
		:IEqualityComparer<HashSet<T>>,IEq
	{
	}
}
