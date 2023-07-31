using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set
{
	/// <summary>
	/// operation on family of sets of type <typeparamref name="T"/>. The eqComparer is the same in each of the sets
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete(nameof(nilnul.set.IOp<T>))]
	public interface IOp<T>
	{
	}
}
