using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.concur.cumulator
{
	/// <summary>
	/// to cumulate 0 args, the result is Omega
	/// to cumulate 1 arg, the result is the Omega concur Arg, the rsult is Arg if arg is included in omega.
	///		if some members of Arg is outside Omega, the result is Arg sect with Omega
	///			in other words, Arg is mappedInto/constrainted into Omega.
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	/// <remarks>
	/// </remarks>
	public interface ICumulate<TEl> 
	{
		
	}
}
