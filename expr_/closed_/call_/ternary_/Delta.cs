using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr_.typed_;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_.ternary_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Delta<T>
		:

nilnul.obj.calc_._ternary.OpArgs<
	nilnul.set.op_.ternary_.<T>
	,
	expr_.var_.Omega<T>
	,
	nilnul.set.expr_.closed_.CallI<T>
	,
	nilnul.set.expr_.closed_.CallI<T>

	>
		,
		closed_.CallI<T>
	{
		public expr_.var_.Omega<T> omega
		{
			get
			{
				return this.arg;
			}
		}


		public Delta(
			expr_.var_.Omega<T> omega
			, CallI<T> arg
			, CallI<T> arg1

			)
			: base(
			nilnul.set.op_.ternary_.Concur<T>.Unison
				  ,
			omega
			, arg, arg1
		)
		{
		}

		public Delta(
			expr_.var_.Omega<T> omega
			,
			ParameterExpression x
			,
			ParameterExpression y
		)
		: base(
			nilnul.set.op_.ternary_.Concur<T>.Unison
			  ,
			  omega
			  ,
			new set.expr_.closed_.call_.unary_.Noop<T>(
				x
			)
			  ,
			new set.expr_.closed_.call_.unary_.Noop<T>(
				y
			)
		)
		{
		}

		public CommonI<T> toCommon()
		{
			return new closed_.common_.binary_.Union<T>(
				new ternary_.Neither<T>(
					this.omega
					,
					this.arg, this.arg1
				).toCommon()

				,
				new closed_.common_.binary_.Intersect<T>(
					this.arg.toCommon(), this.arg1.toCommon()
				)
			);
		}


		public obj.expr.be_.typed_.generi.vow.Ee<HashSet<T>> generi => new(
			new nilnul.obj.Expr4(
			(MethodCallExpression)this
			)
		);


		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => generi.ee.expr;

		public obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>> closed => new obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>>(this);

		static public implicit operator System.Linq.Expressions.MethodCallExpression(Delta<T> expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(
expr.op),
				expr.op.GetType().GetMethod("op", new[] {
					typeof(HashSet<T>)
					,
					typeof(HashSet<T>)
					,
					typeof(HashSet<T>)
				}
				)

				,
				expr.arg.expr.ee
				,
				expr.arg1.expr.ee
				,
				expr.arg2.expr.ee
			);
		}
	}
}
