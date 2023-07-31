using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._set_
{
	/// <summary>
	/// has a member
	/// </summary>
	/// <remarks>
	/// Logician George Boolos strongly urged that "contains" be used for membership only, and "includes" for the subset relation only. [4]
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.set._has.CollectionI<T>))]
	public interface HasI<T>
	{
		/// <summary>
		/// ∋,
		/// </summary>
		/// <param name="member"></param>
		/// <returns></returns>
		/// <remarks>
		/// alias: contains
		/// ∌ means not has
		/// ∈ means member of
		/// ∉ is not member of
		/// </remarks>
		bool has(T member);
	}
}
