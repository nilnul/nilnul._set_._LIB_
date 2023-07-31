using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms_.canonic
{

	
	public class Sum<T>
		:
		nilnul.obj.Box_ofIn<Canonic<T>>

	{
		public Canonic<T> distinct { get { return boxed; } }

		/// <summary>
		/// a set
		/// </summary>
		/// <remarks>
		/// </remarks>
		public Set<T> vars { get {

				return distinct.eeByRef.FirstOrDefault()?.vars ??
				new Set<T>()
//Enumerable.Empty<Var<T>>()
					;
			} }

		public Sum(in Canonic<T> val) : base(val)
		{
		}

		public Sum(Canonic<T> x) : base(x)
		{
		}

		/// <summary>
		/// prod( ), this is the omega.
		/// </summary>
		public Sum():this(new Canonic<T>())
		{
		}

		public  string _phraseAsSum()
		{
			return $"sum( {nilnul.objs._PhraseX._Phrase(this.distinct.eeByRef)} )";
		}
		public  string _phraseAsJoin()
		{
			return $" {nilnul.objs._PhraseX._Phrase(this.distinct.eeByRef," | ")} ";
		}
		public override string ToString()
		{
			var j = _phraseAsJoin();
			if (j==string.Empty)
			{
				return "0";
			}
			return j;
		}


		public static Sum<T> Of(Minterm<T> maxterm)
		{
			return new Sum<T>(  Canonic<T>.Of (maxterm) );
		}
		public static Sum<T> Of(Var<T> var)
		{
			return Of(  Minterm<T>.Of(var));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="summands">isovars, but might be nondistinct; </param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public static Sum<T> _Of_0isovars4minterms(IEnumerable<Ballot<T>> summands)
		{
			return  Sum<T>.Of_eachAsMinterm(
				ballots_.isokeys_.distinct.of_.coerce_._OfIsovarsX._RemoveRepetives_0isokeys(summands)
			); ;
		}

		public static Sum<T> Of_eachAsMinterm(IEnumerable<Ballot<T>> ballots)
		{
			return new Sum<T>(
				 Canonic<T>.Of_eachAsMinterm(ballots)
			);
		}
	}


}
