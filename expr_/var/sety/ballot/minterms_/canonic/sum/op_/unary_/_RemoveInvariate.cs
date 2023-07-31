using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms_.canonic.sum.op_.unary_
{
	/// <summary>
	/// some variables' change will not affect the result.
	/// remove them by:
	///		1) for each var
	///			1) split the minterms into two groups, one with the var, the other with the complement of the var
	///			2) if the two groups are the same, then this var is redundant.
	/// </summary>
	internal class _RemoveInvariate
	{
	}
}
