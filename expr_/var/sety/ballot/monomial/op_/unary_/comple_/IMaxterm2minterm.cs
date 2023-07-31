using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.monomial.op_.unary_.comple_
{
	/// <summary>
	/// </summary>
	/// <see cref="nilnul.set.expr_.closed_.common_.binary_.except_.comple_._OfMintermX"/>
	public interface IMaxterm2minterm
		:IComplement
	{
	}

	/// <summary>
	/// </summary>
	static public class _Maxterm2mintermX
	{
		/// <summary>
		/// complement
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="maxterm"></param>
		/// <returns>
		/// <see cref="IMinterm"/>
		/// </returns>
		static public IEnumerable<(Var<T> Key, bool)> Complement2minterm<T>(
			set.expr_.var.sety.ballot.Maxterm<T> maxterm
		)
		{
			///  eg:
			///		!(x | !z)
			///
			/// = !x & !(!z)
			/// = !x & z

			var terms4product = maxterm.ballot.Select(
				kv => (kv.Key, !kv.Value)
			);

			// this is a minterm

			return terms4product;
		}

	}

}
