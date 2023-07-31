using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_.orand_
{
	/// <summary>
	/// for union,
	///		it's semigrp as long as it's closed;
	///	for sect
	///		it's semigrp as long as it's closed;
	///		
	///	sect is semiditributive with respect to union, which is implied by <see cref="IUnionInter"/>
	/// </summary>
	/// <remarks>
	/// This requires the <see cref="IUnionInter"/> is closed for either operators; and other constraints for semiring then can be inferred;
	/// </remarks>
	interface ISemiring:IUnionInter, IClosed4either
	{
	}



}
