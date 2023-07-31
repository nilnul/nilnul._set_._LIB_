using nilnul.set.expr_.var.sety.ballot;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.valves
{
	/// <summary>
	/// eg:
	///		xy
	///		x!y
	///		x!x
	///		{}
	///		xx
	///			,as this is a set of vote
	/// </summary>
	public interface IProduct { }

	static public class _ProductX
	{
		static public Minterm<T> ProductAsMinterm0nul<T>(
			IEnumerable<(Var<T> var, bool val)> votes
		)
		{
			var r = new var.sety.Ballot<T>();
			foreach ( var vote in votes )
			{
				var v = vote.var;
				var val= vote.val;
	
				if (r.ContainsKey(v ) )
				{
					if ( r[v] != val ) // eg: x !x  , this is not a minterm.
					{
						return null;
					}
					//else:  no need to add to dict;
				}
				else
				{
					r.Add(v, val);
				}

			}
			return new Minterm<T>(r);

		}
		static public Minterm<T> ProductAsMinterm0nul<T>(
			IEnumerable<Vote<T>> votes
		) {
			return ProductAsMinterm0nul<T>(
				votes.Select(
					v=>(v.var,v.val)
				)
			);
		}

		static public Minterm<T> ProductAsMinterm0nul<T>(IEnumerable<KeyValuePair<Var<T>, bool>> votes)
		{
			return ProductAsMinterm0nul<T>(
				votes.Select(
					v=>(v.Key,v.Value)
				)
			);

		}
	}


	
}
