using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms_.canonic.sum
{

	/// <see cref="eq_.ByEnrollNewVars{TEl}"/>
	/// <summary>
	/// by remove ineffective vars;
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Eq<TEl>
		: IEqualityComparer<Sum<TEl>>
	{
		/// <summary>
		///  eg:
		///		x
		///		xy + x!y
		///
		///  are the two equal?
		///  here we might transform them into isovars.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public bool Equals(Sum<TEl> x, Sum<TEl> y)
		{
			IEnumerable<Ballot<TEl>> ballots = sum.pars_.ineffective._RemoveX.Remove(x);
			var ballots4y = sum.pars_.ineffective._RemoveX.Remove(y);

			var pars4x = ballots_.isokeys._ParsX.Pars(ballots);

			var pars4y= ballots_.isokeys._ParsX.Pars(ballots4y);

			if (
				expr_.var.sety._EqX.Eq(pars4x, pars4y)
			)
			{
				return minterms_.canonic.co_.isovars.be_._EqAsSetX._EqAsSet_0canonic_1canonic_01isokeys(
					ballots
					,
					ballots4y
				);

			}
			return false;

			

		}

		public int GetHashCode(Sum<TEl> obj)
		{
			return 0;
		}


		static public Eq<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq<TEl>>.Unison;
			}
		}

	}
}
