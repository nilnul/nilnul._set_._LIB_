using System.Collections.Generic;
using System.Runtime.Serialization;

namespace nilnul.set
{
	/// <summary>
	/// the values are boolean;
	/// </summary>
	public interface IBallot:IAllot { }

	public class Ballot<T>
		: Dictionary<T, bool>
	{
		public Ballot()
		{
		}

		public Ballot(int capacity) : base(capacity)
		{
		}

		public Ballot(IEqualityComparer<T> comparer) : base(comparer)
		{
		}

		public Ballot(IDictionary<T, bool> dictionary) : base(dictionary)
		{
		}

		public Ballot(int capacity, IEqualityComparer<T> comparer) : base(capacity, comparer)
		{
		}

		public Ballot(IDictionary<T, bool> dictionary, IEqualityComparer<T> comparer) : base(dictionary, comparer)
		{
		}

		protected Ballot(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}



}
