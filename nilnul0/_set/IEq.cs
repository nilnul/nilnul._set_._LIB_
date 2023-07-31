using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._set
{
	/// <summary>
	/// an equalityComparer is preset before defining a set.
	/// </summary>
	/// <remarks>
	/// this is placed in the precontext for sets, not on the set itself. By so doing, <see cref="set.op"/> would be avoided the awkard situation where two inputs have different equalityComparer;
	/// </remarks>
	internal class IElEq
	{
	}
}
