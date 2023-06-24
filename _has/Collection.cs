using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set._has
{
	/// <summary>
	/// has a member
	/// </summary>
	/// <remarks>
	/// Logician George Boolos strongly urged that "contains" be used for membership only, and "includes" for the subset relation only. [4]
	/// </remarks>
	public interface CollectionI<T>
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
		/// vs:
		///		have
		///			have many
		///			have all given;
		bool has(T member);
	}
	/// we can later extend this to infinite set, including discrete infinite, continuum and beyond.
	/// for discrete, it not only inherits this, but also inherits distinct_. IEnumerable (finite, or infinite), ie, we can find one enumerator that enumerate distinct elements, in other words, a stream nonrepeating. <see cref="nilnul.obj.seq_.IDistinct"/>, <see cref="nilnul.obj.stream_.IDistinct"/>
	/// for continuum or beyond, it only inherits this, not inherits IEnumerable.

}
