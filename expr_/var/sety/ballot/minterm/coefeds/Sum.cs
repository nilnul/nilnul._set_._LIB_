using nilnul.set.expr_.var.sety.ballot.minterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterm.coefeds
{

	internal class ISum
	{
	}
	public class Sum<T>
		:
		nilnul.obj.Box_ofIn<IEnumerable<Coefed<T>>>

	{
		public Sum(in IEnumerable<Coefed<T>> val) : base(val)
		{
		}

		public Sum(IEnumerable<Coefed<T>> x) : base(x)
		{
		}

		//public static Sum<T> Of(Var<T> var)
		//{
		//	return new Sum<T>(
		//		new[] {

		//			new Minterm<T>(
		//				new Ballot<T>() {
		//					[var]=true
		//				}
		//			)
		//		}
		//	);
		//}
	}


}
