using nilnul.obj.set.co_.sameEq_.xpn_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.co_.elEqSame_.xpn_
{

	[Serializable]
	public class ElEqNotSameException : Exception
	{
		public ElEqNotSameException() { }
		public ElEqNotSameException(string message) : base(message) { }
		public ElEqNotSameException(string message, Exception inner) : base(message, inner) { }
		protected ElEqNotSameException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		static public void Vow<T>(HashSet<T> x, HashSet<T> y)
		{
			if (x.Comparer != y.Comparer)
			{
				throw new ElEqNotSameException(
					$"the comparers of {x} and {y} are not same;"
				);
			}
		}
	}
}
