using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.monomial.coefed_.monic_
{
	/// <summary>
	/// for <see cref="IMaxterm"/>, the prepended is the empty set:0;
	/// eg:
	///		for maxterm: x | !y, it's transformed into； 0 | x |!y
	/// </summary>
	/// alias:
	///		simple sum
	internal class IMaxtermish:IMonic
	{
	}

}
