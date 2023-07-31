using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{


	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TEl"> as this is of the obj, not the type of the set, hence this type is defined in namespace "nilnul.obj.set.op_.binary_.Delta"</typeparam>
	///
	//[Obsolete(nameof(of_))]
	public class _DeltaX
		
	{
		/// <summary>
		/// with reference to circled plus, which denotes logical Xor
		/// </summary>
		/// <remarks>
		/// the symbol is the xor in bit;
		/// sometimes,
		///		∆ is used.
		/// </remarks>
		public const char Symbol = '^'; // '⊖';	// (U+2296);

		static public HashSet<TEl> _Op_1elEqSame<TEl>(HashSet<TEl> par, HashSet<TEl> par1)
		{
			var r = new HashSet<TEl>(par,par.Comparer );

			r.SymmetricExceptWith(par1);
			return r;

		}

	}
}
