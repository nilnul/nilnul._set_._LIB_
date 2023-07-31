using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.cobiop_.orand_.semi_.rng_
{
	/// <summary>
	///	for intersect
	///		it's not only a semigrp, but also a monoid;
	///		,this requires we have a universal set.
	/// </summary>
	/// <remarks>
	///eg:
	///	{
	///		{a}
	/// }
	///		,
	///		{
	///			{a},{a,b},{a,c},{a,b,c}
	///		}
	/// </remarks>
	internal interface IRing
		:
		IRng
	{
	}
}
