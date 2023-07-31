using nilnul.collection.set;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.collection.set
{
	/// <summary>
	/// type if already defined in a dag, so here is paradox free.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface SetI<T>
		: SetI
	{
		bool contains(T a);

	}
}

namespace nilnul.set
{
	/// <summary>
	/// type if already defined in a dag, so here is paradox free.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface SetI<T>
		:SetI
	{
		bool contains(T a);

	}
}
