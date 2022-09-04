using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.co_.sameEq_.xpn_
{

	[Serializable]
	public class EqNotSameException : Exception
	{
		public EqNotSameException() { }
		public EqNotSameException(string message) : base(message) { }
		public EqNotSameException(string message, Exception inner) : base(message, inner) { }
		protected EqNotSameException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
