using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family_.lattice_
{
	/// 
	/// <summary>
	/// <see cref="IDwelt"/> is a boolean ring;
	/// eg: {{a,b}, {c,d} , {a,b,c,d} , 0}. this is a choosing (no putting back. hence it's not rearrange, which is a selection with placing back) from { {a,b}, {c,d} }, a family of disjoint sets, <see cref="family_.IPartition"/>;
	///
	/// </summary>
	/// <remarks>
	/// eg: {
	///			{},
	///			{a,b}, {c,d} ,{e}
	///			, {a,b,c,d},{a,b,e},{c,d,e}
	///			,{a,b,c,d,e}
	///		}
	///	sub-algebra of powerset.
	///	eg:
	///		{
	///			{}
	///		}
	///	eg:{
	///	{},{a,b}
	/// }
	///	note: empty set is always in.
	///	note: universal set is always in. universal set is the empty set when it's {{}}
	///
	/// the cardinality is 2^n.
	///
	/// </remarks>
	/// 
	internal class IBoolean
	{
	}
}
