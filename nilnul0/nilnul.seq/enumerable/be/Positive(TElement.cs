using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.enumerable.be
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

		public class Asserted
			:nilnul.bit.be.Predicated<IEnumerable<TElement>,Positive<TElement>>


		{
			public Asserted(IEnumerable<TElement> val)
				:base(val)
			{

			}

			public TElement begin{
				get {
					return val.First();
				}
			}
			public TElement end {
				get {
					return val.Last();
				}
			}

		}


		public class Asserted1
			:nilnul.bit.be.Asserted<IEnumerable<TElement>,Positive<TElement>>


		{
			public Asserted1(IEnumerable<TElement> val)
				:base(val)
			{

			}

			public int count {
				get {
					return val.Count();
				}
			}

			public TElement begin{
				get {
					return val.First();
				}
			}
			public TElement end {
				get {
					return val.Last();
				}
			}

		}

	}
}
