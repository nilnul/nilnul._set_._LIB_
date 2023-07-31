using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.unary_
{



	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public interface IComplement<TEl>
		:
		nilnul.set.op_.IUnary<TEl>
		,
		nilnul.set.op_.binary_.except_.IComplement


	{


	}
}
