using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set
{
	/// <summary>
	/// type if already defined in a dag, so here is paradox free.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// finite,
	/// literal or can be transformed to literal.
	/// </remarks>
	/// 
	[Obsolete()]

	public partial interface SetI2<T>
		:IEnumerable<T>
		
		where T:IEquatable<T>
	{

	}
}
