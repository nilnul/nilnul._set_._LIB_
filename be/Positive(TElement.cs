using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.be
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




	}
}
