using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		sop
	///			, euphemism from <see cref="minterms_.canonic.Sum{T}"/>
	///		sum
	///	vs:
	///		sigma, which is for discrete case that might be infinite, while sum is used for finite case only;

	internal class ISop
	{
	}
	public class Sop<T>
		:
		nilnul.obj.Box_ofIn<IEnumerable<Minterm<T>>>

	{
		public IEnumerable<Minterm<T>> minterms { get { return boxed; } }
		public Sop(in IEnumerable<Minterm<T>> val) : base(val)
		{
		}

		public Sop(IEnumerable<Minterm<T>> x) : base(x)
		{
		}

		public Sop():this(Enumerable.Empty<Minterm<T>>())
		{
				
		}

		public Sop(IEnumerable<IEnumerable<(Var<T>, bool)>> newMinEs)
			:this(
				 newMinEs.Select(
					 ballot0=> new Minterm<T>(ballot0)
				)
			)
		{
		}

	

		public Sop(IEnumerable<IEnumerable<KeyValuePair<Var<T>, bool>>> newMintermEs)
			:this(
				 newMintermEs.Select(
					 ballot0=> new Minterm<T>(ballot0)
				)
			)
		{
		}

		public expr_.var.Set<T> vars {
			get {
				return new expr_.var.Set<T>( this.minterms.SelectMany(m => m.ballot.Keys) );
			}
		}

		public minterms_.canonic.Sum<T> toCanonic() {

			/// eg:
			///		x | x&y | !y&z
			///
			/// we need first get the full set of vars.
			///

			var summands = new List<Ballot<T>>();

			var varsOfThis = this.vars;

			/// let's remove repeated ones;

			var mintermsDeduped = this.minterms.Distinct(
				minterm.Eq<T>.Unison
			);

			foreach (var m in mintermsDeduped)
			{

				var unshownVars = varsOfThis.Except( m.ballot.Keys);

				var unshowVarsBallot = nilnul.obj.set._BallotsX._Full_0distinct(
					unshownVars
				);

				foreach (var unshowBallot in unshowVarsBallot)
				{
					var newMinTermStub =new Ballot<T>( m.ballot);

					summands.Add(
						new Ballot<T>(
							newMinTermStub.Concat(unshowBallot )
						)
					);
				}

			}
			return  minterms_.canonic.Sum<T>.Of_eachAsMinterm( summands );

		}

		public  string phraseAsSum()
		{
			return $"sum( { nilnul.objs._PhraseX._Phrase(this.minterms) })";
		}

		public string phraseAsJoin()
		{
			return $" { nilnul.objs._PhraseX._Phrase(this.minterms," | ") }";
		}

		public override string ToString()
		{
			var t = phraseAsJoin();
			if (t==string.Empty)
			{
				return "0";
			}
			return t;
		}

		public static Sop<T> Of(Var<T> var)
		{
			return new Sop<T>(
				new[] {
					new Minterm<T>(
						new Ballot<T>() {
							[var]=true
						}
					)
				}
			);
		}
	}


}
