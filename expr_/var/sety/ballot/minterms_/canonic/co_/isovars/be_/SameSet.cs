using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms_.canonic.co_.isovars.be_
{
	static public class _EqAsSetX
	{


		public static bool _SameSet_01canonic1isovars<TEl>(
			IEnumerable<Minterm<TEl>> x
			,
			IEnumerable< Minterm<TEl>> y
		)
		{
			return nilnul.set._eq_._OnSeqX.Eq(
				x,y
				,
				ballot.minterm.re_.isovars_._eq._SameVal4EachVar<TEl>.Unison
			);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TEl"></typeparam>
		/// <param name="x">
		/// <see cref="minterms_.ICanonic"/>
		/// </param>
		/// <param name="y">
		/// <see cref="minterms_.ICanonic"/>
		///
		/// </param>
		/// <returns></returns>
		static public bool _EqAsSet_0canonic_1canonic_01isokeys<TEl>(
			IEnumerable<Ballot<TEl>> x
			,
			IEnumerable<Ballot<TEl>> y

		)
		{
			return nilnul.set._eq_._OnSeqX.Eq(
				x, y
				,
				ballot.re_.isokeys_._eq._SameVal4EachVar<TEl>.Unison
			);
		}

		public static bool _EqAsSet_0canonic_1canonic_01isokeys<TEl>(
			IEnumerable<
				IEnumerable<KeyValuePair<Var<TEl>, bool>>
			> x
			,
			IEnumerable<
				IEnumerable<KeyValuePair<Var<TEl>, bool>>
			> y
		)
		{
			return _EqAsSet_0canonic_1canonic_01isokeys(
				x.Select(
					m=> new Ballot<TEl>(m)
				)
				,
				y.Select(m1=>new Ballot<TEl>(m1))
			);


		}
	}
}
