using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms_.canonic.sum.eq_
{

	public class ByEnrollNewVars<TEl>
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
			var mergedVars = new var.Set<TEl>(
				x.vars.Concat(y.vars)
			);

			var yVars = y.vars;
			yVars.Except(x.vars);

			var unshowVarsBallot = nilnul.obj.set._BallotsX._Full_0distinct(
				yVars
			);



			var newX= x.distinct.eeByRef.SelectMany(
				m=> unshowVarsBallot.Select(
					n=>
					new Ballot<TEl>(
							m.ballot.Concat(n)
						)
				)
			);

			var xVars = x.vars;
			xVars.Except(y.vars);

			var unshowVarsBallot4y = nilnul.obj.set._BallotsX._Full_0distinct(
				xVars
			);


			var newY= y.distinct.eeByRef.SelectMany(
				m=> unshowVarsBallot4y.Select(
					n=>
					new Ballot<TEl>(
							m.ballot.Concat(n)
						)
				)
			);

			return minterms_.canonic.co_.isovars.be_._EqAsSetX._EqAsSet_0canonic_1canonic_01isokeys(
				newX,newY
			);
			

		}

		public int GetHashCode(Sum<TEl> obj)
		{
			return 0;
		}


		static public ByEnrollNewVars<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<ByEnrollNewVars<TEl>>.Unison;
			}
		}

	}
}
