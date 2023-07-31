using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.setta
{
	public  interface EqI<TEl>
		:IEqualityComparer<
			nilnul.set_.Eq8staticI< Ballot<TEl>, ballot.Eq<TEl> >
		>
	{

	}
}
