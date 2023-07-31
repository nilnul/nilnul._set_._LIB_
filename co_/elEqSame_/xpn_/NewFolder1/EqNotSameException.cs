using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.co_.sameEq_.xpn_
{
	[Obsolete(nameof(nilnul.set.co_.elEqSame_.xpn_.ElEqNotSameException))]

	[Serializable]
	public class EqNotSameException : nilnul.set.co_.elEqSame_.xpn_.ElEqNotSameException
	{
		public EqNotSameException() { }
		public EqNotSameException(string message) : base(message) { }
		public EqNotSameException(string message, Exception inner) : base(message, inner) { }
		protected EqNotSameException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }


	}
}
