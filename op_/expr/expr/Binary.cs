using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.op.expr
{
	public partial class Binary<T>
		:SetI<T>
	{
		public op.BinaryI<T> op { get; set; }

		public SetI<T> a;
		public SetI<T> b;

		public Binary(op.BinaryI<T> op,SetI<T> a,SetI<T> b)
		{
			this.op = op;
			this.a = a;
			this.b = b;

		}



		public bool contains(T a)
		{
			return op.membershipLogic.exec(
				this.a.contains(a)
				,
				this.b.contains(a)
			);
		}
	}
}
