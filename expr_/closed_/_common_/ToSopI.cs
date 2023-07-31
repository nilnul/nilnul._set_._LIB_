﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_._common_
{
	/// <summary>
	/// for var, make it:
	///		identity(var)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ToSopI<T>
	{
		expr_.var.sety.ballot.minterms.Sop<T> toSop();
	}
}
