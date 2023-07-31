using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot
{
	public interface IMinterm:IMonomial { }
	public class Minterm<TEl>
		:
		nilnul.obj.Box_ofIn<sety.Ballot<TEl>>
		,
		IMinterm
	{

		public sety.Ballot<TEl> ballot { get {
				return this.boxed;
		} }
		public Minterm(in Ballot<TEl> val) : base(val)
		{
		}

		public Minterm(Ballot<TEl> x) : base(x)
		{
		}
		public Minterm():this(new Ballot<TEl>())
		{
				
		}

		public Minterm(IEnumerable<(Var<TEl>, bool)> ballot0)
			:this(
				 new Ballot<TEl>(ballot0)
				)
		{
		}

		public Minterm(
			IEnumerable<KeyValuePair<Var<TEl>, bool>> ballot0
		)
		:this(
			 new Ballot<TEl>(ballot0)
		)
		{
		}

		/// <summary>
		/// computed
		/// </summary>
		public expr_.var.Set<TEl> vars
		{
			get
			{
				return new expr_.var.Set<TEl>(this.ballot.Keys);
			}
		}

		public static Minterm<TEl> Of(Var<TEl> var)
		{
			return new Minterm<TEl>(
				Ballot<TEl>.Of(var)
			);
		}

		public  string _phraseAsProd()
		{
			return $"prod({
				nilnul.objs._PhraseX._Phrase(
					this.ballot.Select(a=> var.valve.phrase_._AsNop0complementX.Phrase(a))
					,
					","
				)
			})";
		}
		public  string _phraseAsJoin()
		{
			return $"{
				nilnul.objs._PhraseX._Phrase(
					this.ballot.Select(a=> var.valve.phrase_._AsNop0complementX.Phrase(a))
					,
					" " // to allow !x y, not !xy
				)
			}";
		}

		public override string ToString()
		{
			var j = _phraseAsJoin();
			if (j==string.Empty)
			{
				return "1"; // when used in sum( prod() ) = 1, when vars are empty. if vars are not empty, when vars are,say, {x}, we can get 1 by sum(prod(x), prod(!x) ).
				// note minterm can never be "0";
			}
			return j;
		}


	}

}
