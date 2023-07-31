using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_.binary_
{
	public class Delta<T>
		: closed_.call_.BinaryA<T>
	{
		private set.expr_.var_.Omega<T> _omega;

		public set.expr_.var_.Omega<T> omega
		{
			get { return _omega; }
			set { _omega = value; }
		}

		public Delta( CallI<T> arg, CallI<T> arg1, set.expr_.var_.Omega<T> omega) : base(set.op_.binary_.Delta<T>.Singleton, arg, arg1)
		{
			this._omega = omega;
		}

		public Delta(
			Var<T> x,
			Var<T> y,
			set.expr_.var_.Omega<T> omega
		)
			: base(set.op_.binary_.Delta<T>.Singleton, x, y)
		{
			this._omega = omega;

		}

		public Delta( ParameterExpression x,ParameterExpression constantExpression, set.expr_.var_.Omega<T> omega)
			: base(set.op_.binary_.Delta<T>.Singleton, x, constantExpression)
		{
			this._omega = omega;

		}


		public override CommonI<T> toCommon()
		{
			return 	new closed_.common_.binary_.Union<T>(

				new closed_.call_.binary_.Except<T>(
					arg
					,
					arg1
					,
					this.omega

				).toCommon()
				,
				new closed_.call_.binary_.Except<T>(
					arg1
					,
					arg
					,
					this.omega

				).toCommon()

			);



		}
	}
}
