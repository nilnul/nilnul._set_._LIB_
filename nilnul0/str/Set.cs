using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str
{
	public class Set<TEl>
		:
		nilnul.obj.Set1<nilnul.obj.str_.SeqI2<TEl>>
	{
	

	
	public Set(IEqualityComparer<TEl> elementEq) : base(new nilnul.obj.str_.seq.Eq<TEl>(elementEq))
		{
		}
		

		

		public Set(IEqualityComparer<TEl> elementEq, IEnumerable<SeqI2<TEl>> vars) : base(new nilnul.obj.str_.seq.Eq<TEl>(elementEq), vars)
		{
		}
	}
}
