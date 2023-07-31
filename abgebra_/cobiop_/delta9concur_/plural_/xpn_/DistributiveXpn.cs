using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_.delta9concur_.plural_.xpn_
{

	///
	///
	///<summary>
	///
	/// per testing by literal values or expr, generally it's not distributive.
	///
	/// only when the omega is empty will this be distributive.
	///</summary>

	[Serializable]
	public class DistributiveException : Exception
	{
		public DistributiveException() { }
		public DistributiveException(string message) : base(message) { }
		public DistributiveException(string message, Exception inner) : base(message, inner) { }
		protected DistributiveException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
