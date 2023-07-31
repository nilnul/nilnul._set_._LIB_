using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	

	/// <summary>
	/// a collection of elements, with an equality comparer.
	/// we use the <see cref="HashSet{T}"/>, where the elEq is provided in runtime;
	/// </summary>
	/// <remarks>
	/// by exposing the elEq, we can share the eq for many <see cref="nilnul.set.op_"/>, avoiding the awkard sitution where two sets are of different eqs.
	/// the operation can then operate on Seq, as we assume that they assume same eqs;
	/// </remarks>
	/// 
	/// <typeparam name="T"></typeparam>
	///
	//[Obsolete(nameof(nilnul.obj.SetI2<T>))]
	public interface SetI1<T>
		:
		ISet<T>
		,
		IEnumerable<T>
		,
		_set_.elEq_.OvMemberI<T>

	{


	}




}
