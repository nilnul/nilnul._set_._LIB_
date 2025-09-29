using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{
	/// <summary>
	/// memberEq of the set is statically typed, and with a new() ctor to generate unison.
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	/// memberEq typed, generic, then defaulted.
	/// alias:
	///		elEq8static
	public interface Eq8defaultI<TEl, TEq>
		:
		nilnul.obj.op_.BinaryI<
			nilnul.set_.Eq8static<TEl,TEq>
		>
		,
		nilnul.set.op_.IBinary
		where TEq: IEqualityComparer<TEl>,new()
	{

	}

	
}
