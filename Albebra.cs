using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	/// <summary>
	/// when studying the op itself without operands is not enough, we need to study it with operands --hence Algebra.
	/// given a type,
	///		the set, and a sortie of opI{type}.
	/// </summary>
	/// 
	public interface IAbgebra:_abgebra_.IOps,_abgebra_.ISet
	{
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">
	///
	/// </typeparam>
	public interface IAbgebra<T> :IAbgebra
		,
		_abgebra_.ISet<T>
	{ }
}
