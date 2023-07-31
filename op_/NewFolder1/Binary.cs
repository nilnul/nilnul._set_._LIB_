using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"> cuz this is in the namespace of <see cref="nameof(nilnul.obj)"/>, hence "T" is a subtype of obj.</typeparam>
	///
	[Obsolete(nameof(nilnul.set.op_.BinaryI<T>))]
	public interface BinaryI<T>:
		nilnul.obj.set.IOp<T>
		,
		nilnul.obj.op_.BinaryI<
			nilnul.obj.SetI2<T>	//the set must be of the same eqComparer
		>
		
	{

	}
}
