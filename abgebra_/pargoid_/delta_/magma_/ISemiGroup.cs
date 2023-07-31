using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_.delta_.magma_
{
	/// <summary>
	/// every magma is a semigrp
	/// eg:
	///		{Phi}
	///		{A, Phi}
	///		
	///		{A,B, the delta of A and B, and the empty set}
	///			here, the univrsal set is not in.
	///			eg:
	///				{x,y},{x,z}, {y,z}, {}
	/// </summary>
	public interface ISemiGroup:IMagma
	{
	}
}
