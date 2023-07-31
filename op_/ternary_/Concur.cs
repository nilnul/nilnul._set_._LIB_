using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.ternary_
{
	public interface IConcur :IContextCurried{ }

	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	/// alias:
	///		xnor
	///		eq
	///		equiv
	///		iff
	///		iif
	public class Concur<TEl>
		:
		nilnul.set.op_.TernaryI<TEl>
		,
		IConcur
	{

		public HashSet<TEl> op(HashSet<TEl> omega, HashSet<TEl> par1, HashSet<TEl> par2)
		{
			if (omega.Comparer != par1.Comparer | par1.Comparer!=par2.Comparer)
			{
				throw new obj.set.co_.sameEq_.xpn_.EqNotSameException(
					$"the eq comparers of {omega} and {par1} and {par2} are not the same"
				);

			}
			var r = new HashSet<TEl>(omega,omega.Comparer);



			r.ExceptWith(binary_._DeltaX._Op_1elEqSame(par1,par2));


			return r;
		}
		public override string ToString()
		{
			return "~";
		}
		static public Concur<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Concur<TEl>>.Unison;
			}
		}



	}
}
