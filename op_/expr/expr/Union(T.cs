using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.op.expr
{
	public partial class Union<T>
		:
		Tuple<SetI<T>,SetI<T>>
		,
		BinaryI<T>
	{

		public Union(SetI<T> item1,SetI<T> item2):base(item1,item2)
		{
		}


		public bool contains(T a)
		{
			return this.Item1.contains(a) || this.Item2.contains(a);
		}
	}
}
