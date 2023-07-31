using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefeds_.isovars_
{
	/// <summary>
	/// like means the maxterm is the same, the coef might be different or not;
	///
	///  unlike means the maxterm is not the same, no matter what the coef is 
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Unlike<TEl> :
		maxterm.coefeds.vow.en_.Vow8stati<
			TEl
			,
			maxterm.coefeds.be_.isovars_.unlike.Vow<TEl>
		>
		,IMaxterms
	{
		public IEnumerable<Coefed<TEl>> coefeds { get { return base.eeByRef; } }
		public Unlike(in IEnumerable<Coefed<TEl>> val) : base(val)
		{
		}

		public Unlike(IEnumerable<Coefed<TEl>> val) : base(val)
		{
		}


		public Unlike():this(
			Enumerable.Empty<Coefed<TEl>>()
		)
		{
				
		}
	}
}
