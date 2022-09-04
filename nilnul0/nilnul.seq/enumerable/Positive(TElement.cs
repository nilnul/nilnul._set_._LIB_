using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.enumerable
{
	public partial class Positive<TElement>
		:
		nilnul.bit.be.FroFunc<IEnumerable<TElement>>
	{

		static public bool Be(IEnumerable<TElement> val) {

			return (val.Count()>0);
		
		}

		public Positive(
		):base(Be)
		{

		}

		public class Noun
			:nilnul.bit.be.Predicated<IEnumerable<TElement>,Positive<TElement>>
		{
			public Noun(IEnumerable<TElement> val)
				:base(val)
			{

			}

		}



	}
}
