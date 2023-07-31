using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{

	public class Expr<T>
		:
		nilnul.obj.expr_.typed_.Generi<HashSet<T>>
		,
		ExprI<T>
	{
		public Expr(obj.ExprI4 val) : base(val)
		{
		}

		public Expr(obj.Expr4 val) : base(val)
		{
		}

		public Expr(Expression sys) : base(sys)
		{
		}
	}

}
