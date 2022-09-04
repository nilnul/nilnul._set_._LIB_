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
	public interface IAlgebra:_algebra_.IOps,_algebra_.ISet
	{
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">
	///
	/// </typeparam>
	public interface IAlgebra<T> :IAlgebra
		,
		_algebra_.ISet<T>
	{ }
}
