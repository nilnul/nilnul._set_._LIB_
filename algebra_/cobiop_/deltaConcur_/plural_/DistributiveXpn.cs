using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.cobiop_.deltaConcur_.plural_
{

	///when check:	concur is distributive with respect to delta?
	///		x CONCUR (y DELTA z)
	///		= NOT( x DELTA y DELTA z)
	///
	///		on the other hand
	///			x CONCUR y DELTA (x CONCUR z)
	///			=   DELTA (  x & z | !x&!z)
	///			= 
	///	the ans: negative.
	///
	///<summary>
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
