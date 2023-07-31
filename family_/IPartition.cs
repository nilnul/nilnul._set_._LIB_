using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family_
{
	/// <summary>
	/// any two members are <see cref="set.re_._DisjointX"/>
	/// </summary>
	/// <remarks>
	/// eg:
	///		{}
	///		,
	///		{{}} // empty member is generally disallowed
	///		,
	///		{{a},{b}}
	///		,
	///		{{a},{b},{}}// empty member is generally disallowed
	///	
	/// </remarks>
	/// shall we exclude empty set as a member of the family?
	/// <see cref="nilnul.set.abgebra_.cobiop_.delta9sect_.IRing"/>, we may prefer to exlude the empty set;
	public interface IPartition:IFamily
	{
	}
}
