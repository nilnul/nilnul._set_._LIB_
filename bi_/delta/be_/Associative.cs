using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.delta.be_
{
	/*
	 for any x:  
x ∈(A⊖B⊖C)
= (x ∈ (A⊖B) ) ^ ( x ∈ C )
= x ∈ A ^ x ∈ B ^ x ∈ C
= x ∈ A ^ ( x ∈ B ^ x ∈ C)
= x ∈ (A ⊖ (B⊖C) )
∴  
A⊖B⊖C  = A⊖ (B⊖C)
where ⊖ means symmetric difference, ^ means either or.
	 */
	/// this is a modulo add.
	/// <summary>
	/// 
	/// </summary>
	class Associative
	{
	}
}
