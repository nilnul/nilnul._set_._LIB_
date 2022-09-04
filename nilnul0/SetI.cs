using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	

	/// <summary>
	/// a collection of elements, with an equality comparer.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete(nameof(nilnul.obj.SetI2<T>))]
	public interface SetI<T> : ISet<T>
		,
		IEnumerable<T>
		,
		_set_.MemberEqI_ovMember<T>

	{


	}


}
