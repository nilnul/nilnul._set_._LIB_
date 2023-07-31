using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_
{
	/// <summary>
	/// a family and two binary ops:[union, intersect], acting as the add and multi for abstract algebra;
	/// </summary>
	/// <remarks>
	/// it's distributive as implied;
	/// this is closed operation by default, an implicit assumption.
	/// </remarks>
	/// alias:
	///		or9and
	///		orand
	///		
	///		
	public interface IUnionInter
		:ICoBiop
	{
	}
}
