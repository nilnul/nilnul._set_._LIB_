using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{



	/// <summary>
	/// the result is the complement of the delta of the input.
	/// To get the complement, we need to know the left operand of the except operation. So this op is not defined without an explicit omega.
	///
	/// <see cref="Concur{TEl}"/>'s members.
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	/// concur
	///		the two sets say the same to a member.
	/// deltaNeg
	/// equiv
	public interface IConcur<TEl>
		:
		nilnul.set.op_.IBinary<TEl>
		,
		nilnul.obj.op_.binary_.ICommutable
		,
		nilnul.obj.op_.binary_.IAssociative



	{


	}
}
