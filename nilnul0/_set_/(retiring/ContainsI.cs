using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.slew._set_
{
	/// <summary>
	/// as long as an instnce has such method, it's a set. So a set might be infinite; but it must have a mechanism to determine whether an element is inside- that is, it has an edge.
	/// </summary>
	///
	[Obsolete()]
	public interface ContainsI<T>
	{
		bool contains(T element);
	}
}
