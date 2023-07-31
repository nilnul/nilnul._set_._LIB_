using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.re_
{
	/// <summary>
	/// the antonym/complement of in. If A is in B, the B incS A.
	/// Nomenclature:
	///		the relation "in"'s complement. INC
	/// </summary>
	/// <remarks>
	/// Logician George Boolos strongly urged that "contains" be used for membership only, and "includes" for the subset relation only. [4]
	/// </remarks>
	/// alias:
	///		include
	///			, as some mathematicians suggest.
	/// 
	///		have
	///			, which means "has" every in the latter set; whileas "inside" means: every is "in" the latter set.
	///			, sometimes confusing with <see cref="set.IHas"/>
	///		contain
	///			, which is a synonym of <see cref="set.IHas"/>
	///		
	///		superset
	///		supset
	public interface ISupset
	{
	}
}
