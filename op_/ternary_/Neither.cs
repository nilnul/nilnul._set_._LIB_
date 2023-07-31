using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.ternary_
{
	public interface INeither : IContextCurried { }

	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	/// alias:
	///		nor,
	///			, is usally reserved for binary. here neither is used for ternay;
	///		neither
	public class Neither<TEl>
		:
		nilnul.set.op_.TernaryI<TEl>
		,
		INeither
	{

		public HashSet<TEl> op(HashSet<TEl> par, HashSet<TEl> par1, HashSet<TEl> par2)
		{
			if (par.Comparer != par1.Comparer | par1.Comparer!=par2.Comparer)
			{
				throw new obj.set.co_.sameEq_.xpn_.EqNotSameException(
					$"the eq comparers of {par} and {par1} and {par2} are not the same"
				);

			}
			var r = new HashSet<TEl>(par,par.Comparer);

			r.ExceptWith(par1);
			r.ExceptWith(par2);
			return r;
		}
		public override string ToString()
		{
			return "nor";
		}
		static public Neither<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Neither<TEl>>.Unison;
			}
		}



	}
}
