using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.ballot_
{
	public class Eq8implict<T>
		:
		nilnul.set.Ballot<T>
	{
		public Eq8implict()
		{
		}

		public Eq8implict(int capacity) : base(capacity)
		{
		}

		

		public Eq8implict(IDictionary<T, bool> dictionary) : base(dictionary)
		{
		}

	
	

		protected Eq8implict(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
