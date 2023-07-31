using System.Collections.Generic;

namespace nilnul.set_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	public interface Eq8staticI<T, TEq>
		:
		nilnul.SetI1<T>
		,
		nilnul.ISet<T,TEq>
		where TEq : IEqualityComparer<T>, new()

	{

	}
}
