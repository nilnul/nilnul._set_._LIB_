using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	/// memberEq typed, generic, then defaulted.
	///
	[Obsolete(nameof(binary_.Eq8defaultI<TEl, TEq>))]
	public interface ElEqDefaultI<TEl, TEq>
		:
		nilnul.obj.op_.BinaryI<
			nilnul.obj.set_.EqDefaulted<TEl,TEq>
		>
		,
		nilnul.set.op_.IBinary
		where TEq: IEqualityComparer<TEl>,new()
	{

	}

	
}
