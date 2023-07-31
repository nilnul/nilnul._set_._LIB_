using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety
{
	public class Ballot<TEl>
		:

		Dictionary<expr_.Var<TEl>, bool>
	{
		public Ballot()
		{
		}

		public Ballot(int capacity) : base(capacity)
		{
		}

		//public Ballot(IEqualityComparer<Var<T>> comparer) : base(comparer)
		//{
		//}

		public Ballot(IDictionary<Var<TEl>, bool> dictionary) : base(dictionary)
		{
		}

		public Ballot(IEnumerable<(Var<TEl>, bool)> ballot0)
		{
			ballot0.Each(
				vote0 => base.Add(vote0.Item1, vote0.Item2)
			);
			
		}

		public Ballot(IEnumerable<KeyValuePair<Var<TEl>, bool>> ballot0)
		{
			ballot0.Each(
				vote0 => base.Add(vote0.Key, vote0.Value)
			);
		}



		//public Ballot(int capacity, IEqualityComparer<Var<T>> comparer) : base(capacity, comparer)
		//{
		//}

		//public Ballot(IDictionary<Var<T>, bool> dictionary, IEqualityComparer<Var<T>> comparer) : base(dictionary, comparer)
		//{
		//}

		protected Ballot(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public static Ballot<TEl> Of(Var<TEl> var)
		{
			return new Ballot<TEl>() { [var] = true };
		}

		public bool has(Vote<TEl> vote)
		{
			return this.Any(
				a=> vote.var == a.Key && vote.val ==a.Value
			);

		}
	}
}
