using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var
{
	/// <summary>
	/// (var, bool)
	/// </summary>
	/// alias:
	///		assign
	///		vote
	///			,veto
	public interface IVote
	{
	}
	public interface IVote<TEl> : IVote { }

	public record Vote<TEl>
		:IVote<TEl>
		//KeyValuePair<Var<T>,bool>

	{
		public Var<TEl> var;
		public bool val;

		public Vote(Var<TEl> var, bool val)
		{
			this.var = var;
			this.val = val;
				
		}

		static public bool operator ==(Vote<TEl> vote, KeyValuePair<Var<TEl>, bool> attr) {
			return vote.var == attr.Key && vote.val == attr.Value;
		}
		static public bool operator !=(Vote<TEl> vote, KeyValuePair<Var<TEl>, bool> attr) {
			return !(vote == attr);
		}

		static public bool operator ==( KeyValuePair<Var<TEl>, bool> attr, Vote<TEl> vote) {
			return vote==attr;
		}

		static public bool operator !=( KeyValuePair<Var<TEl>, bool> attr, Vote<TEl> vote) {
			return !(vote==attr);
		}

	}

}
