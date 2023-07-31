using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.common_.binary_.except_.comple_
{
	/// <summary>
	/// <see cref="var.setty.ballot.monomial.op_.unary_.comple_.IMinterm2maxterm"/>
	/// </summary>
	static public class _OfMintermX
	{
		/// <summary>
		/// return a maxterm.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="minterm"></param>
		/// <returns>
		/// <see cref="set.expr_.var.setty.ballot.IMaxterm"/>
		/// </returns>
		///
		[Obsolete(nameof(expr_.var.setty.ballot.monomial.op_.unary_.comple_._Minterm2maxtermX))]
		static public IEnumerable<(Var<T> Key, bool)> OfMinterm<T>(
			set.expr_.var.setty.ballot.Minterm<T> minterm
		) {
			return expr_.var.setty.ballot.monomial.op_.unary_.comple_._Minterm2maxtermX.Complement2maxterm(minterm);
		}
	}
}
