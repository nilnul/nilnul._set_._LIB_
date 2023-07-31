using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace nilnul.set.expr_.var.sety.ballot.monomial.op_.unary_.comple_
{
	/// <summary>
	/// <see cref="nilnul.set.expr_.closed_.common_.binary_.except_.comple_._OfMintermX"/>
	/// </summary>
	public interface IMinterm2maxterm
		: IComplement
	{
	}

	/// <summary>
	/// </summary>
	static public class _Minterm2maxtermX
	{
		/// <summary>
		/// return a maxterm.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="minterm"></param>
		/// <returns></returns>
		static public IEnumerable<(Var<T> Key, bool)> Complement2maxterm<T>(
			set.expr_.var.sety.ballot.Minterm<T> minterm
		)
		{
			///  eg:
			///		!(x!z)
			///
			/// = !x + !(!z)
			/// = !x + z

			var terms4sum = minterm.ballot.Select(
				kv => (kv.Key, !kv.Value)
			);

			// this is a maxterm

			return terms4sum;
		}

	}


}
