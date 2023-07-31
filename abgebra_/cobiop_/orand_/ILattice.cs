using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_.orand_
{
	/// <summary>
	/// A set equipped with two commutative and associative binary operations ∨ ("join") and ∧ ("meet") that are connected by the absorption law (a ¤ (a ⁂ b) = a ⁂ (a ¤ b) = a) is called a lattice; 
	/// </summary>
	public interface ILattice
		:
		IUnionInter
		,

		_lattice.IClosed4either

	{
	}
}
