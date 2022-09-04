using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family
{
	/// <summary>
	/// a set (here is the family) and a collection of op (generally, binary; and also  some nary op which is the member itself.)
	/// </summary>
	/// calculus
	public interface IAlgebra: nilnul.set.IAlgebra<nilnul.obj.ISet>
	{
	}
	public interface IAlgebra<T> : IAlgebra
		,
		nilnul.set.IAlgebra<nilnul.obj.ISet<T>>

	{ }
}
