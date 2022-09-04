using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection
{
	/// <summary>
	/// only trivia sets. Finite set, though finite, has to be defined using natural number, which can be arbitrarily large.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// </remarks>
	public partial interface SetI3<T>
		: IEnumerable<T>

	{

	}
}
