using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_
{
	public interface IPargoid:family.IAlgebra
	{
	}

	public interface IPargoid<T> : IPargoid, family.IAlgebra<T> { }
}
