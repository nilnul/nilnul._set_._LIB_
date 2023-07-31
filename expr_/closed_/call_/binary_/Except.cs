using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_.binary_
{
	public class Except<T>
		: closed_.call_.BinaryA<T>
	{
		private set.expr_.var_.Omega<T> _omega;

		public set.expr_.var_.Omega<T> omega
		{
			get { return _omega; }
			set { _omega = value; }
		}

		public Except( CallI<T> arg, CallI<T> arg1, set.expr_.var_.Omega<T> omega) : base(set.op_.binary_.Except<T>.Unison, arg, arg1)
		{
			this._omega = omega;
		}

		public Except( ParameterExpression x, ParameterExpression constantExpression, set.expr_.var_.Omega<T> omega)
			: base(set.op_.binary_.Except<T>.Unison, x, constantExpression)
		{
			this._omega = omega;

		}

		public override CommonI<T> toCommon()
		{
			return 	new closed_.common_.binary_.Intersect<T>(
				arg.toCommon()
				,
				new closed_.common_.binary_.except_.Complement<T>(
					this.omega
					,
					arg1.toCommon()
				)
			);	
		}
	}
}
