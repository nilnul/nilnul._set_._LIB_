using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set._has_
{
	/// <summary>
	/// has a member
	/// </summary>
	/// <remarks>
	/// Logician George Boolos strongly urged that "contains" be used for membership only, and "includes" for the subset relation only. [4]
	/// </remarks>
	public interface HasI<T>
		:_has.CollectionI<T>
	{
		
	}
}
