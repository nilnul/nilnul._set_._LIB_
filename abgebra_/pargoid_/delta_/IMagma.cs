using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_.delta_
{
	/// <summary>
	/// closed with respect to the operation.
	/// </summary>
	/// <remarks>
	/// the family can be:
	///		empty;
	///		singleton: {x}, where x^x =0; so x has to be {}
	///		doubleton: {0,x}
	///		{0,{x},{y},    {x,y} }, where the latter ones are gurantined by closedness;
	///		{0,{x}, {x,y}    ,{y} }
	///		{0,{x,z}, {x,y}    ,{y,z} }
	/// 
	/// </remarks>
	/// <seealso cref="set.family_.ITopology"/>
	public interface IMagma:IDelta
	{
	}
}
