using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.concur.cumulator.be_
{
	/// <summary>
	/// if some members of Arg is outside Omega, the result is Arg sect with Omega
	///			in other words, Arg is mappedInto/constrainted into Omega.
	///		So generally it is not unard
	/// If omega has all the instances of type <typeparamref name="TEl"/>, then it's unard.
	///
	/// In all, whether it's unard is dependent on the inner state of the operator, or the family this operator is applied within as in <see cref="set.family.algebra_.pargoid_.concur_.dwelt_.magma_.Monoid"/>
	/// That's why we need to discuss this as a <see cref="set.family.algebra_.pargoid_.IConcur{T}"/>, not as an op.
	/// </summary>
	public interface IUnard<TEl>
		
	{

	}
}
