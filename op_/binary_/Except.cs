using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{
	public interface IExcept:IBinary { }
	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Except<TEl>
		:
		
		nilnul.set.op_.BinaryI1<TEl>
		,
		IExcept

	{
		
		public const char Symbol = '-'; 
		public HashSet<TEl> op(HashSet<TEl> par, HashSet<TEl> par1)
		{
			if (par.Comparer != par1.Comparer)
			{
				throw new obj.set.co_.sameEq_.xpn_.EqNotSameException(
					$"the eq comparers of {par} and {par1} are not the same"
				);

			}

			var r = new HashSet<TEl>(par,par.Comparer);

			r.Except(par1);
			return r;

		}

		public override string ToString()
		{
			return Symbol.ToString();
		}

		static public Except<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Except<TEl>>.Unison;
			}
		}



	}
}
