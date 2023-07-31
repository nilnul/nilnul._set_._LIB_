using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_.delta9sect_.grp4aug_.monoid4mul_.ring_.plural_.commutive_._domain
{
	/// nonnil & nonnil ?= nonnil?
	/// eg:
	///		x& ~x = 0
	///	so generally this cannot satisfied, unless:
	///
	/// eg:
	///		{
	///			0
	///			,
	///			{a}
	///		}
	///	eg:
	///		{
	///			0
	///			,
	///			{a}
	///			,
	///			{a,b}
	///		}
	///		
	///	excluding:
	///		{
	///			0
	///			,
	///			{a}
	///			,
	///			{a,b}
	///			,
	///			{a,c}
	///			,
	///			{b,c} // {a,b} ^ {a,c}
	///				//but {b,c} &{a} =0
	///		}
	///		
	///	for: 	
	///		{
	///			0
	///			,
	///			{a,b}
	///			,
	///			{a,c}
	///			,
	///			{b,c} // {a,b} ^ {a,c}
	///			,
	///			{a}		// {a,b} & {a,c}
	///			
	///				//but {b,c} &{a} =0
	///		}
	///		
		///
	/// <summary>
	/// </summary>
	internal class IClosed4nonnil8mul
	{
	}
}
