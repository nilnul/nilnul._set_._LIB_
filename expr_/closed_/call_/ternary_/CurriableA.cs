using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr_.typed_;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_.ternary_
{
	/// <summary>
	/// nor;
	/// neither;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class CurriableA<T>
		:

nilnul.obj.calc_._ternary.OpArgs<
	nilnul.set.op_.TernaryI<T>
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


		public CurriableA(
			nilnul.set.op_.TernaryI<T> op,
			expr_.var_.Omega<T> omega
			, CallI<T> arg
			, CallI<T> arg1

			)
			: base(
			op
				  ,
			omega
			, arg, arg1
		)
		{
		}

		public CurriableA(
			nilnul.set.op_.TernaryI<T> op,

			expr_.var_.Omega<T> omega
			,
			expr_.Var<T> x
			,
			expr_.Var<T> y
		)
		: base(
			op
			  ,
			  omega
			  ,

				x

			  ,

				y

		)
		{
		}
		public CurriableA(
			nilnul.set.op_.TernaryI<T> op,
			expr_.var_.Omega<T> omega
			,
			ParameterExpression x
			,
			ParameterExpression y
		)
		: base(
			op
			  ,
			  omega
			  ,
			new set.expr_.Var<T>(
				x
			)
			  ,
			new set.expr_.Var<T>(
				y
			)
		)
		{
		}




		public obj.expr.be_.typed_.generi.vow.Ee<HashSet<T>> generi => new(
			new nilnul.obj.Expr4(
			(MethodCallExpression)this
			)
		);


		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => generi.ee.expr;

		public obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>> closed => new obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>>(this);

		IOp _call_.OpI.op => base.op;

		public override string ToString()
		{
			var leftTxt = this.arg1.ToString();

			//var thisOp = op;
			if (!set.op.co.be_.lex_.Precedence.Unison.be(this.arg1.op, op))
			{
				leftTxt = $"({leftTxt})";
			}
			var rightTxt = this.arg2.ToString();
			if (set.op.co.be_.lex_.Precedence.Unison.be( this.op, op))
			{
				rightTxt = $"({rightTxt})";


			}
			return $"{leftTxt}{this.op}{rightTxt}";
		}

		public abstract CommonI<T> toCommon();

		static public implicit operator System.Linq.Expressions.MethodCallExpression(CurriableA<T> expr)
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
