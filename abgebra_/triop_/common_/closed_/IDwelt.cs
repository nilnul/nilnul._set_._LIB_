using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.triop_.common_.closed_
{
	/// <summary>
	/// there is at least one <see cref="set.of_.INary"/>;
	/// </summary>
	/// <remarks>
	/// eg:
	///		{
	///			0
	///		}
	///	eg:
	///		{
	///			a	//this is also the universal set; !a is the empty set;
	///			,
	///			0	
	///		}
	///		
	///	eg:
	///		{
	///			a
	///			,
	///			b	// then we'll get !a,!b
	///			,
	///			{a,b}// we will get the universal by union all.
	///			,
	///			0	
	///		}
	///
	/// this is a boolean ring;
	/// eg: {{a,b}, {c,d} , {a,b,c,d} , 0}. this is a choosing (no putting back. hence it's not rearrange, which is a selection with placing back) from { {a,b}, {c,d} }, a family of disjoint sets, <see cref="family_.IPartition"/>;
	///
	/// 
	/// </remarks>
	internal class IDwelt
	{
	}
}
