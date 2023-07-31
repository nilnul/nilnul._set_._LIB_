using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.ballot_
{
	public class Eq8static<T,TEq>
		:
		nilnul.set.Ballot<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Eq8static() : base( 
				 nilnul._obj.typ_._UnisonX<TEq>.Unison
				)
		{
		}

		public Eq8static(int capacity) : base(capacity, nilnul._obj.typ_._UnisonX<TEq>.Unison
)
		{
		}

		

		public Eq8static(IDictionary<T, bool> dictionary) : base(dictionary, nilnul._obj.typ_._UnisonX<TEq>.Unison
)
		{
		}

	
	

		protected Eq8static(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
