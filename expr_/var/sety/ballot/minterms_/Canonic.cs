using nilnul.set.expr_.var.sety.ballot.minterms_.isovars_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.set.expr_.var.sety.ballot.minterms_
{
	public class Canonic<TEl> :
		minterms.vow.en_.Vow8stati<
			TEl
			,
			minterms.be_.isovars_.distinct.Vow<TEl>
		>
		,
		IDistinct
		,IMinterms
	{
		public Canonic(in IEnumerable<Minterm<TEl>> val) : base(val)
		{
		}

		public Canonic(IEnumerable<Minterm<TEl>> val) : base(val)
		{
		}

		public Canonic():this( Enumerable.Empty<Minterm<TEl>>())
		{
				
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">isovars, but might be nondistinct.</param>
		/// <returns></returns>
		static public Canonic<TEl> _Of_0isovars(IEnumerable<Minterm<TEl>> val) 
		{

			return new Canonic<TEl>(
				canonic.of_.coerce_._OfIsovarsX._RemoveRepetives_0isovars(
					val
				)
			);
		}

		public static Canonic<TEl> Of(Minterm<TEl> minterm)
		{
			return new Canonic<TEl>(new[] {minterm });

		}

		public static Canonic<T> Of_eachAsMinterm<T>(IEnumerable<Ballot<T>> ballots)
		{
			return new Canonic<T>(ballots.Select(b=> new Minterm<T>(b)));
		}
	}
}
