using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_.delta9sect_
{
	/// <summary>
	/// for delta,
	///		it's semigrp as long as it's closed;
	///	for sect
	///		it's semigrp as long as it's closed;
	///		
	///	sect is semiditributive with respect to delta, which is implied by <see cref="deltaSect"/>
	/// </summary>
	/// <remarks>
	/// This requires the <see cref="deltaSect"/> is closed for either operators; and other constraints for semiring then can be inferred;
	/// </remarks>
	public interface ISemiring: IClosed4either
	{
	}



}
